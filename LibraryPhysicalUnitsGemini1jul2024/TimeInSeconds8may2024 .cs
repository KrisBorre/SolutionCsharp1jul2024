namespace LibraryPhysicalUnitsGemini1jul2024
{
    public class TimeInSeconds8may2024 : ITime6apr2024
    {
        private readonly double seconds;

        public TimeInSeconds8may2024(double seconds, double milliseconds)
        {
            this.seconds = seconds + milliseconds / 1000;
        }

        public double GetInSeconds()
        {
            return seconds;
        }

        public double GetInMilliseconds()
        {
            return seconds * 1000;
        }
    }
}
