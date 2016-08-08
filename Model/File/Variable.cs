using Model.Pictures;
using Model.References;
using System.Collections.Generic;

namespace Model.File
{
    public class Variable
    {
        public int VariableLevel { get; }

        public string VariableName { get;  }

        public Variable Redefines { get; set; }

        public int Occurs { get; set; }

        public int Offset { get; set; }

        public int ByteLength { get; set; }

        public IPic Picture { get;  }

        private string Code { get; set; }

        public List<Variable> Variables { get;  }

        public Variable ParentVariable { get; set; }

        public FileReference CopyReference { get; set; }

        public int Index { get; set; }

        public string VariableDefinition => $"{VariableLevel.ToString("D2")} {VariableName} {Picture}";

        public Variable Root
        {
            get
            {
                if (ParentVariable == null) return VariableLevel == 1 ? this : null;

                var result = ParentVariable;
                while ((result.VariableLevel != 1 || result.VariableLevel != 77) && result.ParentVariable != null)
                    result = result.ParentVariable;
                return result;
            }
        }

        public Variable()
        {
        }

        public Variable(int variableLevel, string variableName, IPic picture, string code, Variable parentVariable)
        {
            VariableLevel = variableLevel;
            VariableName = variableName;
            Picture = picture;
            Code = code;
            ParentVariable = parentVariable;
            Variables = new List<Variable>();
        }

        public string GetLevelAndName()
        {
            return VariableLevel.ToString("D2") + "  " + VariableName;
        }

        public override string ToString()
        {
            return $"{VariableLevel} {VariableName}, Variables: {Variables.Count}";
        }
    }
}
