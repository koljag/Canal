﻿using Canal.Utils;
using Model.References;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Procedure : CobolTreeNode
    {
        public new string Name { get; set; }

        public string OriginalSource { get; set; }

        #region References

        public List<PerformReference> PerformReferences { get; set; }

        public List<GoToReference> GoToReferences { get; set; }

        public List<ProcedureReference> References { get { return PerformReferences.Concat<ProcedureReference>(GoToReferences).ToList(); } }

        public List<PerformReference> IsReferencedBy { get; set; }

        public List<FileReference> CallReferences { get; set; }

        #endregion

        public Dictionary<Variable, UsedAs> Variables { get; set; }

        private readonly List<string> _lines;

        public int LinesOfCode { get { return _lines.Count; } }

        public Procedure()
        {
        }

        public Procedure(string name, string text, int indexInSourceCode)
            : this(name, indexInSourceCode)
        {
            OriginalSource = text;

            _lines = text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        protected Procedure(string name, int indexInSourceCode)
            : base(name, indexInSourceCode)
        {
            Name = name;
            PerformReferences = new List<PerformReference>();
            GoToReferences = new List<GoToReference>();
            IsReferencedBy = new List<PerformReference>();
            CallReferences = new List<FileReference>();
            Variables = new Dictionary<Variable, UsedAs>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}