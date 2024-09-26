namespace LibraryPhysicalUnitsGemini1jul2024
{
    public class TimeCalculation13may2024
    {
        public static ITime6apr2024 Add(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double totalSeconds = time1.GetInSeconds() + time2.GetInSeconds();
            return new TimeInSeconds8may2024(totalSeconds, 0);
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
            return milliseconds / 60000;
        }

        public static double ConvertMinutesIntoMilliseconds(double minutes)
        {
            return minutes * 60000;
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
            return hours * 3600000;
        }

        public static double ConvertMillisecondsIntoHours(double milliseconds)
        {
            return milliseconds / 3600000;
        }
    }
}
