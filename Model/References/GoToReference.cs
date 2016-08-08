namespace Model.References
{
    public class GoToReference : ProcedureReference
    {
        public GoToReference(string referencedProcedure) : base(referencedProcedure)
        {
        }

        public override string ToString()
        {
            return $"GO TO {ReferencedProcedure}";
        }
    }
}
