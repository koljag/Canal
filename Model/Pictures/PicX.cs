namespace Model.Pictures
{
    public class PicX : IPic
    {
        private string value;

        public int Length { get; }

        public string Value
        {
            get { return value; }
            set { this.value = value.StartsWith("SPACE") ? new string(' ', Length) : value.Trim('\"', '"', '\\'); }
        }

        public CompType CompType { get; set; }

        public int ByteLength => Length;

        public PicX(int length)
        {
            Length = length;
        }

        public override string ToString()
        {
            return $"PIC X{(Length > 1 ? "(" + Length + ")" : string.Empty)}";
        }
    }
}