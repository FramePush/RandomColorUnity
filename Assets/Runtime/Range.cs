namespace RandomColorUnity
{
    public class Range
    {
        public int Min { get; private set; }
        public int Max { get; private set; }

        public Range(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}