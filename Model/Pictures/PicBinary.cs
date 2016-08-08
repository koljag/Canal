namespace Model.Pictures
{
    public class PicBinary : IPic
    {
        private const int length = 1;

        private const string value = "";

        private const CompType compType = CompType.None;

        public int Length => length;

        public string Value
        {
            get { return value; }
            set { }
        }

        public CompType CompType
        {
            get { return compType; }
            set { }
        }

        public int ByteLength => 1;

        public override string ToString()
        {
            return "BINARY";
        }
    }
}
