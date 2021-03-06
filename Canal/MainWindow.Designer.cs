﻿namespace Canal
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOBOLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOBOLProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.revertChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level88ToEnumConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCopybooksIntoSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reRunAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFilesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueAnonymouslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showSourceOnGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileTabs = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.projectView = new Canal.UserControls.FilesView();
            this.saveProjectDialog = new System.Windows.Forms.SaveFileDialog();
            this.openProjectDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1384, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.toolStripSeparator7,
            this.revertChangesToolStripMenuItem,
            this.toolStripSeparator6,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOBOLFileToolStripMenuItem,
            this.cOBOLProjectToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // cOBOLFileToolStripMenuItem
            // 
            this.cOBOLFileToolStripMenuItem.Name = "cOBOLFileToolStripMenuItem";
            this.cOBOLFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cOBOLFileToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.cOBOLFileToolStripMenuItem.Text = "COBOL File";
            this.cOBOLFileToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
            // 
            // cOBOLProjectToolStripMenuItem
            // 
            this.cOBOLProjectToolStripMenuItem.Enabled = false;
            this.cOBOLProjectToolStripMenuItem.Name = "cOBOLProjectToolStripMenuItem";
            this.cOBOLProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.cOBOLProjectToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.cOBOLProjectToolStripMenuItem.Text = "COBOL Project";
            this.cOBOLProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Enabled = false;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Enabled = false;
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(215, 6);
            // 
            // revertChangesToolStripMenuItem
            // 
            this.revertChangesToolStripMenuItem.Name = "revertChangesToolStripMenuItem";
            this.revertChangesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.revertChangesToolStripMenuItem.Text = "Revert Changes...";
            this.revertChangesToolStripMenuItem.Click += new System.EventHandler(this.revertChangesToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(215, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level88ToEnumConverterToolStripMenuItem,
            this.insertCopybooksIntoSourceToolStripMenuItem,
            this.reRunAnalysisToolStripMenuItem,
            this.codeGeneratorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem.Text = "Tools";
            // 
            // level88ToEnumConverterToolStripMenuItem
            // 
            this.level88ToEnumConverterToolStripMenuItem.Name = "level88ToEnumConverterToolStripMenuItem";
            this.level88ToEnumConverterToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.level88ToEnumConverterToolStripMenuItem.Text = "Level 88 to Enum Converter";
            this.level88ToEnumConverterToolStripMenuItem.Click += new System.EventHandler(this.Level88ToEnumConverterToolStripMenuItemClick);
            // 
            // insertCopybooksIntoSourceToolStripMenuItem
            // 
            this.insertCopybooksIntoSourceToolStripMenuItem.Name = "insertCopybooksIntoSourceToolStripMenuItem";
            this.insertCopybooksIntoSourceToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.insertCopybooksIntoSourceToolStripMenuItem.Text = "Insert Copybooks into Source...";
            this.insertCopybooksIntoSourceToolStripMenuItem.Click += new System.EventHandler(this.insertCopybooksIntoSourceToolStripMenuItem_Click);
            // 
            // reRunAnalysisToolStripMenuItem
            // 
            this.reRunAnalysisToolStripMenuItem.Name = "reRunAnalysisToolStripMenuItem";
            this.reRunAnalysisToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.reRunAnalysisToolStripMenuItem.Text = "Re-Run Analysis";
            this.reRunAnalysisToolStripMenuItem.Click += new System.EventHandler(this.reRunAnalysisToolStripMenuItem_Click);
            // 
            // codeGeneratorToolStripMenuItem
            // 
            this.codeGeneratorToolStripMenuItem.Enabled = false;
            this.codeGeneratorToolStripMenuItem.Name = "codeGeneratorToolStripMenuItem";
            this.codeGeneratorToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.codeGeneratorToolStripMenuItem.Text = "Code Generator...";
            this.codeGeneratorToolStripMenuItem.Visible = false;
            this.codeGeneratorToolStripMenuItem.Click += new System.EventHandler(this.codeGeneratorToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextTabToolStripMenuItem,
            this.previousTabToolStripMenuItem,
            this.showFilesViewToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // nextTabToolStripMenuItem
            // 
            this.nextTabToolStripMenuItem.Name = "nextTabToolStripMenuItem";
            this.nextTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.nextTabToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.nextTabToolStripMenuItem.Text = "Next Tab";
            this.nextTabToolStripMenuItem.Click += new System.EventHandler(this.nextTabToolStripMenuItem_Click);
            // 
            // previousTabToolStripMenuItem
            // 
            this.previousTabToolStripMenuItem.Name = "previousTabToolStripMenuItem";
            this.previousTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Tab)));
            this.previousTabToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.previousTabToolStripMenuItem.Text = "Previous Tab";
            this.previousTabToolStripMenuItem.Click += new System.EventHandler(this.previousTabToolStripMenuItem_Click);
            // 
            // showFilesViewToolStripMenuItem
            // 
            this.showFilesViewToolStripMenuItem.Checked = true;
            this.showFilesViewToolStripMenuItem.CheckOnClick = true;
            this.showFilesViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFilesViewToolStripMenuItem.Name = "showFilesViewToolStripMenuItem";
            this.showFilesViewToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.showFilesViewToolStripMenuItem.Text = "Show Files View";
            this.showFilesViewToolStripMenuItem.Click += new System.EventHandler(this.showFilesViewToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLogToolStripMenuItem,
            this.toolStripSeparator3,
            this.reportIssueToolStripMenuItem,
            this.reportIssueAnonymouslyToolStripMenuItem,
            this.toolStripSeparator5,
            this.showSourceOnGitHubToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // showLogToolStripMenuItem
            // 
            this.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            this.showLogToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.showLogToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.showLogToolStripMenuItem.Text = "Show Log";
            this.showLogToolStripMenuItem.Click += new System.EventHandler(this.ShowLogToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue on GitHub";
            this.reportIssueToolStripMenuItem.Click += new System.EventHandler(this.ReportIssueToolStripMenuItemClick);
            // 
            // reportIssueAnonymouslyToolStripMenuItem
            // 
            this.reportIssueAnonymouslyToolStripMenuItem.Name = "reportIssueAnonymouslyToolStripMenuItem";
            this.reportIssueAnonymouslyToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.reportIssueAnonymouslyToolStripMenuItem.Text = "Report Issue Anonymously";
            this.reportIssueAnonymouslyToolStripMenuItem.Click += new System.EventHandler(this.reportIssueAnonymouslyToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(212, 6);
            // 
            // showSourceOnGitHubToolStripMenuItem
            // 
            this.showSourceOnGitHubToolStripMenuItem.Name = "showSourceOnGitHubToolStripMenuItem";
            this.showSourceOnGitHubToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.showSourceOnGitHubToolStripMenuItem.Text = "Show Source on GitHub";
            this.showSourceOnGitHubToolStripMenuItem.Click += new System.EventHandler(this.showSourceOnGitHubToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // FileTabs
            // 
            this.FileTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTabs.Location = new System.Drawing.Point(0, 0);
            this.FileTabs.Margin = new System.Windows.Forms.Padding(2);
            this.FileTabs.Name = "FileTabs";
            this.FileTabs.SelectedIndex = 0;
            this.FileTabs.Size = new System.Drawing.Size(1190, 738);
            this.FileTabs.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.projectView);
            this.splitContainer.Panel1MinSize = 190;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.FileTabs);
            this.splitContainer.Size = new System.Drawing.Size(1384, 738);
            this.splitContainer.SplitterDistance = 190;
            this.splitContainer.TabIndex = 2;
            // 
            // projectView
            // 
            this.projectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectView.Location = new System.Drawing.Point(0, 0);
            this.projectView.Name = "projectView";
            this.projectView.Size = new System.Drawing.Size(190, 738);
            this.projectView.TabIndex = 0;
            // 
            // saveProjectDialog
            // 
            this.saveProjectDialog.Filter = "Canal Project File|*.canal";
            this.saveProjectDialog.RestoreDirectory = true;
            this.saveProjectDialog.Title = "Save Project...";
            // 
            // openProjectDialog
            // 
            this.openProjectDialog.Filter = "Canal Project File|*.canal";
            this.openProjectDialog.Title = "Open Project...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "CANAL Cobol Analyzer";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl FileTabs;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem level88ToEnumConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCopybooksIntoSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem reportIssueAnonymouslyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showSourceOnGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem reRunAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeGeneratorToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private UserControls.FilesView projectView;
        private System.Windows.Forms.ToolStripMenuItem showFilesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOBOLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOBOLProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveProjectDialog;
        private System.Windows.Forms.OpenFileDialog openProjectDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem revertChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

