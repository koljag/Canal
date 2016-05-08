﻿namespace Model
{
    public class DivisionAndSectionFlags
    {
        public int? Identification { get; set; }

        public int? Environment { get; set; }

        public int? Data { get; set; }

        public int? Procedure { get; set; }

        public int? WorkingStorage { get; set; }

        public int? Linkage { get; set; }

        public bool AllDivisionsFound()
        {
            return Identification.HasValue && Environment.HasValue && Data.HasValue && Procedure.HasValue;
        }
    }
}