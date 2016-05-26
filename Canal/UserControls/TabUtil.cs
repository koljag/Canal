﻿using Canal.Properties;
using Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Util;
using Util.Events;

namespace Canal.UserControls
{
    public class TabUtil
    {
        private readonly TabControl _tabControl;

        private readonly MainWindow _parent;

        public TabUtil(TabControl tabControl, MainWindow parent)
        {
            _parent = parent;
            _tabControl = tabControl;
            _tabControl.DrawMode = TabDrawMode.Normal;
            _tabControl.MouseDown += TabControlOnMouseDown;
        }

        public override string ToString()
        {
            return string.Format("TabUtil, {0} TabPages, Selected: {1}", _tabControl.TabCount, _tabControl.SelectedIndex);
        }

        private IEnumerable<FileControl> GetFileControls()
        {
            return (from TabPage tabPage in _tabControl.TabPages
                    select tabPage.Controls.Find("FileControl", false)
                    .FirstOrDefault(foundTab => foundTab is FileControl))
                    .OfType<FileControl>().ToList();
        }

        public void SetTabName(string text)
        {
            _tabControl.SelectedTab.Text = text;
        }

        public bool TryShowTab(string filepath, Variable currentVar = null)
        {
            try
            {
                foreach (var tab in from TabPage tab in _tabControl.TabPages
                                    let fileControl = tab.Controls.Find("FileControl", false)
                                    .FirstOrDefault(foundTab => foundTab is FileControl) as FileControl
                                    where fileControl != null && fileControl.CobolFile.FileReference.FilePath == filepath
                                    select tab)
                {
                    _tabControl.SelectedTab = tab;
                    Logger.Info("Switching to tab {0}: {1}", tab.TabIndex, tab.Text);
                    if (currentVar != null)
                        CurrentFileControl.FindInCodeBox(currentVar.VariableName, false, false, false, true);
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                Logger.Error("Error trying to show tab {0}: {1}.", filepath, exception.Message);
                return false;
            }
        }

        private void TabControlOnMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            //Looping through the controls.
            for (int i = 0; i < _tabControl.TabPages.Count; i++)
            {
                Rectangle r = _tabControl.GetTabRect(i);

                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);

                if (r.Contains(mouseEventArgs.Location) && mouseEventArgs.Button == MouseButtons.Middle || closeButton.Contains(mouseEventArgs.Location))
                {
                    CloseTab(i);
                    return;
                }
            }
        }

        public void AddTab(string filename = "")
        {
            Logger.Info("Adding tab for file {0}", filename == "" ? "new File" : filename);

            var fileControl = new FileControl(filename, _parent);

            var newTab = new TabPage(fileControl.CobolFile.Name + "     X");

            fileControl.UsedFileTypesChanged += UsedFileTypesChanged;
            fileControl.SavedVersionChanged += (sender, args) => SetTabName(@"* " + newTab.Text);
            fileControl.FileSaved += (sender, args) => SetTabName(newTab.Text.TrimStart('*', ' '));
            FileUtil.Instance.FileCacheChanged += RefreshFileView;

            newTab.Controls.Add(fileControl);
            _tabControl.Controls.Add(newTab);
            _tabControl.SelectTab(newTab);
        }

        private void RefreshFileView(object sender, FileCacheChangedEventArgs fileCacheChangedEventArgs)
        {
            Logger.Info("Refreshing files view.");

            foreach (var fileControl in GetFileControls())
            {
                if (fileControl.InvokeRequired)
                {
                    var control = fileControl;
                    fileControl.Invoke(new MethodInvoker(() => control.RefreshFileView()));
                }
                else
                    fileControl.RefreshFileView();
            }
        }

        private void UsedFileTypesChanged(object sender, UsedFileTypesChangedEventArgs usedFileTypesChangedEventArgs)
        {
            Logger.Info("Used file types changed.");

            foreach (var fileControl in GetFileControls())
            {
                fileControl.RefreshUsedFileTypes(sender, usedFileTypesChangedEventArgs);
            }
        }

        public bool CloseTab(int index = -1)
        {
            Logger.Info("Closing tab {0}.", index);

            var tabIndex = index < 0 ? _tabControl.SelectedIndex : index;

            var fileControl = (FileControl)_tabControl.TabPages[tabIndex].Controls.Find("FileControl", false).FirstOrDefault(tab => tab is FileControl);

            if (fileControl == null)
            {
                try
                {
                    _tabControl.TabPages.RemoveAt(index);
                }
                catch (Exception exception)
                {
                    Logger.Warning("Tried to close tab at index {0}, failed: {1}.", index, exception.Message);
                }
                return true;
            }

            if (!fileControl.UnsavedChanges || MessageBox.Show(Resources.ReallyCloseThisTab, Resources.CloseTab, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // TODO dispose everything
                fileControl.Dispose();
                _tabControl.TabPages.RemoveAt(tabIndex);
                return true;
            }
            return false;
        }

        public bool CloseAllTabs()
        {
            Logger.Info("Closing all tabs.");

            for (int tabIndex = 0; tabIndex < _tabControl.TabCount; tabIndex++)
            {
                if (!CloseTab(tabIndex))
                    return false;
            }

            return true;
        }

        public FileControl CurrentFileControl
        {
            get { return _tabControl.SelectedTab == null ? null : (FileControl)_tabControl.SelectedTab.Controls.Find("FileControl", false).FirstOrDefault(); }
        }

        public void ShowStartTab()
        {
            Logger.Info("Showing start tab");

            var newTab = new TabPage("Start" + "     X");
            var firstTabPage = new FirstTabPage(_parent) { Dock = DockStyle.Fill };
            newTab.Controls.Add(firstTabPage);
            _tabControl.Controls.Add(newTab);
            _tabControl.SelectTab(newTab);
        }

        public void ShowNextTab()
        {
            _tabControl.SelectTab((_tabControl.SelectedIndex + 1) % _tabControl.TabCount);
        }

        public void ShowPreviousTab()
        {
            // since c# does not _really_ implement modulo...
            var index = (_tabControl.SelectedIndex - 1) % _tabControl.TabCount;

            _tabControl.SelectTab(index < 0 ? index + _tabControl.TabCount : index);
        }

        public void TryShowTab(int index)
        {
            if (index < _tabControl.TabCount)
                _tabControl.SelectTab(index);
        }
    }
}