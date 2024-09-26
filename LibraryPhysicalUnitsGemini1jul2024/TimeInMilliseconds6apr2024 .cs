namespace LibraryPhysicalUnitsGemini1jul2024
{
    public class TimeInMilliseconds6apr2024 : ITime6apr2024
    {
        private readonly double milliseconds;

        public TimeInMilliseconds6apr2024(double seconds, double milliseconds)
        {
            this.milliseconds = seconds * 1000 + milliseconds;
        }

        public double GetInSeconds()
        {
            return milliseconds / 1000;
        }

        public double GetInMilliseconds()
        {
            return milliseconds;
        }
    }
}
