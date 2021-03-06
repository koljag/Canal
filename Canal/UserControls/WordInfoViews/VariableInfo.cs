﻿using Model.File;
using System.Windows.Forms;
using Util;

namespace Canal.UserControls.WordInfoViews
{
    public partial class VariableInfo : UserControl
    {
        private readonly FileControl _parent;

        public VariableInfo(Variable variable, FileControl parent)
        {
            InitializeComponent();
            _parent = parent;
            var treeNode = FillVariableTreeView(variable);

            VariableInfoTreeView.SetTree(treeNode);

            VariableInfoTreeView.OnVariableSelected += (sender, clickedVariable) =>
            {
                if (clickedVariable.Root != null && clickedVariable.Root.CopyReference != null)
                    _parent.MainWindow.OpenFile(clickedVariable.Root.CopyReference.FilePath, clickedVariable);
            };
        }

        private TreeNode FillVariableTreeView(Variable variable)
        {
            var newNode = VariablesUtil.Instance.ConvertToTreeNode(variable);

            if (variable.ParentVariable != null)
            {
                // save variable node
                var temp = newNode;
                var parent = variable.ParentVariable;

                // new node for parent variable
                newNode = new TreeNode(variable.ParentVariable.GetLevelAndName()) { Tag = variable.ParentVariable };

                // add parents' children (siblings and self)
                foreach (var sibling in variable.ParentVariable.Variables)
                {
                    newNode.Nodes.Add(sibling == variable
                        ? temp
                        : new TreeNode(sibling.GetLevelAndName()) { Tag = sibling });
                }

                // go further up, add grandparents etc.
                while (parent.ParentVariable != null)
                {
                    newNode = new TreeNode(parent.ParentVariable.GetLevelAndName(), new[] { newNode })
                    {
                        Tag = parent.ParentVariable
                    };

                    parent = parent.ParentVariable;
                }
            }

            return newNode;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            VariableInfoTreeView.Dispose();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
