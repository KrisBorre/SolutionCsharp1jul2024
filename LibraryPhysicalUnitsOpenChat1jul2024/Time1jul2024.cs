namespace LibraryPhysicalUnitsOpenChat1jul2024
{
    // Interface for time in seconds
    public interface ITime6apr2024
    {
        double GetInSeconds();
    }

    // Interface for time in milliseconds
    public interface ITimeInMilliseconds
    {
        double GetInMilliseconds();
    }

    // Class for time in seconds
    public class TimeInSeconds8may2024 : ITime6apr2024
    {
        private double seconds;

        public TimeInSeconds8may2024(double seconds)
        {
            this.seconds = seconds;
        }

        public double GetInSeconds()
        {
            return seconds;
        }
    }

    // Class for time in milliseconds
    public class TimeInMilliseconds6apr2024 : ITimeInMilliseconds
    {
        private double milliseconds;

        public TimeInMilliseconds6apr2024(double milliseconds)
        {
            this.milliseconds = milliseconds;
        }

        public double GetInMilliseconds()
        {
            return milliseconds;
        }
    }

    // Static class for time calculations
    public static class TimeCalculation13may2024
    {
        public static ITime6apr2024 Add(ITime6apr2024 time1, ITimeInMilliseconds time2)
        {
            double totalSeconds = time1.GetInSeconds() + time2.GetInMilliseconds() / 1000;
            return new TimeInSeconds8may2024(totalSeconds);
        }

        public static double ConvertMillisecondsIntoSeconds(double milliseconds)
        {
            return milliseconds / 1000;
        }

        public static double ConvertSecondsIntoMilliseconds(double seconds)
        {
            return seconds * 1000;
        }

        public static double ConvertHoursIntoSeconds(double hours)
        {
            return hours * 3600;
        }

        public static double ConvertSecondsIntoHours(double seconds)
        {
            return seconds / 3600;
        }

        public static double ConvertMinutesIntoSeconds(double minutes)
        {
            return minutes * 60;
        }

        public static double ConvertSecondsIntoMinutes(double seconds)
        {
            return seconds / 60;
        }

        public static double ConvertMillisecondsIntoMinutes(double milliseconds)
        {
            return milliseconds / (1000 * 60);
        }

        public static double ConvertMinutesIntoMilliseconds(double minutes)
        {
            return minutes * (1000 * 60);
        }

        public static double ConvertMinutesIntoHours(double minutes)
        {
            return minutes / 60;
        }

        public static double ConvertHoursIntoMinutes(double hours)
        {
            return hours * 60;
        }

        public static double ConvertHoursIntoMilliseconds(double hours)
        {
            return hours * 3600 * 1000;
        }

        public static double ConvertMillisecondsIntoHours(double milliseconds)
        {
            return milliseconds / (1000 * 3600);
        }
    }
}
