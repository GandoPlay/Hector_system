namespace Hatal_idf
{
    public class Classification
    {
        private int rate = 0;
        private int urgency = 0;

        public Classification() { }

        public int Urgency { get => urgency; set => urgency = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}