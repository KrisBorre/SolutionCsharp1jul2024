namespace LibraryPhysicalUnitsDeepSeek1jul2024
{
    public interface ITime6apr2024
    {
        double GetInSeconds();
        double GetInMilliseconds();
    }

    public class TimeInSeconds8may2024 : ITime6apr2024
    {
        private double seconds;

        public TimeInSeconds8may2024(double seconds, double milliseconds)
        {
            this.seconds = seconds + milliseconds / 1000;
        }

        public double GetInSeconds() => seconds;

        public double GetInMilliseconds() => seconds * 1000;
    }

    public class TimeInMilliseconds6apr2024 : ITime6apr2024
    {
        private double milliseconds;

        public TimeInMilliseconds6apr2024(double seconds, double milliseconds)
        {
            this.milliseconds = seconds * 1000 + milliseconds;
        }

        public double GetInSeconds() => milliseconds / 1000;

        public double GetInMilliseconds() => milliseconds;
    }

    public static class TimeCalculation13may2024
    {
        public static ITime6apr2024 Add(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double totalMilliseconds = time1.GetInMilliseconds() + time2.GetInMilliseconds();
            return new TimeInMilliseconds6apr2024(totalMilliseconds / 1000, totalMilliseconds % 1000);
        }

        public static double ConvertMillisecondsIntoSeconds(double time) => time / 1000;

        public static double ConvertSecondsIntoMilliseconds(double time) => time * 1000;

        public static double ConvertHoursIntoSeconds(double time) => time * 3600;

        public static double ConvertSecondsIntoHours(double time) => time / 3600;

        public static double ConvertMinutesIntoSeconds(double time) => time * 60;

        public static double ConvertSecondsIntoMinutes(double time) => time / 60;

        public static double ConvertMillisecondsIntoMinutes(double time) => ConvertSecondsIntoMinutes(ConvertMillisecondsIntoSeconds(time));

        public static double ConvertMinutesIntoMilliseconds(double time) => ConvertSecondsIntoMilliseconds(ConvertMinutesIntoSeconds(time));

        public static double ConvertMinutesIntoHours(double time) => time / 60;

        public static double ConvertHoursIntoMinutes(double time) => time * 60;

        public static double ConvertHoursIntoMilliseconds(double time) => ConvertSecondsIntoMilliseconds(ConvertHoursIntoSeconds(time));

        public static double ConvertMillisecondsIntoHours(double time) => ConvertSecondsIntoHours(ConvertMillisecondsIntoSeconds(time));
    }
}
