namespace LibraryPhysicalUnitsChatGPT1jul2024
{
    public interface ITime6apr2024
    {
        double GetInSeconds();
        double GetInMilliseconds();
    }

    public class TimeInSeconds8may2024 : ITime6apr2024
    {
        private double _timeInSeconds;
        private double _tolerance;

        public TimeInSeconds8may2024(double timeInSeconds, double tolerance = 0)
        {
            _timeInSeconds = timeInSeconds;
            _tolerance = tolerance;
        }

        public double GetInSeconds()
        {
            return _timeInSeconds;
        }

        public double GetInMilliseconds()
        {
            return _timeInSeconds * 1000;
        }

        // Square method
        public double Square()
        {
            return _timeInSeconds * _timeInSeconds;
        }

        // Operator Overloads
        public static TimeInSeconds8may2024 operator +(TimeInSeconds8may2024 t1, TimeInSeconds8may2024 t2)
        {
            return new TimeInSeconds8may2024(t1._timeInSeconds + t2._timeInSeconds);
        }

        public static TimeInSeconds8may2024 operator -(TimeInSeconds8may2024 t1, TimeInSeconds8may2024 t2)
        {
            return new TimeInSeconds8may2024(t1._timeInSeconds - t2._timeInSeconds);
        }

        public static TimeInSeconds8may2024 operator *(TimeInSeconds8may2024 t, double scalar)
        {
            return new TimeInSeconds8may2024(t._timeInSeconds * scalar);
        }

        public static TimeInSeconds8may2024 operator *(double scalar, TimeInSeconds8may2024 t)
        {
            return new TimeInSeconds8may2024(t._timeInSeconds * scalar);
        }

        public static TimeInSeconds8may2024 operator /(TimeInSeconds8may2024 t, double scalar)
        {
            return new TimeInSeconds8may2024(t._timeInSeconds / scalar);
        }
    }

    public class TimeInMilliseconds6apr2024 : ITime6apr2024
    {
        private double _timeInMilliseconds;
        private double _tolerance;

        public TimeInMilliseconds6apr2024(double timeInMilliseconds, double tolerance = 0)
        {
            _timeInMilliseconds = timeInMilliseconds;
            _tolerance = tolerance;
        }

        public double GetInMilliseconds()
        {
            return _timeInMilliseconds;
        }

        public double GetInSeconds()
        {
            return _timeInMilliseconds / 1000;
        }
        // Operator Overloads
        public static TimeInMilliseconds6apr2024 operator +(TimeInMilliseconds6apr2024 t1, TimeInMilliseconds6apr2024 t2)
        {
            return new TimeInMilliseconds6apr2024(t1._timeInMilliseconds + t2._timeInMilliseconds);
        }

        public static TimeInMilliseconds6apr2024 operator -(TimeInMilliseconds6apr2024 t1, TimeInMilliseconds6apr2024 t2)
        {
            return new TimeInMilliseconds6apr2024(t1._timeInMilliseconds - t2._timeInMilliseconds);
        }

        public static TimeInMilliseconds6apr2024 operator *(TimeInMilliseconds6apr2024 t, double scalar)
        {
            return new TimeInMilliseconds6apr2024(t._timeInMilliseconds * scalar);
        }

        public static TimeInMilliseconds6apr2024 operator *(double scalar, TimeInMilliseconds6apr2024 t)
        {
            return new TimeInMilliseconds6apr2024(t._timeInMilliseconds * scalar);
        }

        public static TimeInMilliseconds6apr2024 operator /(TimeInMilliseconds6apr2024 t, double scalar)
        {
            return new TimeInMilliseconds6apr2024(t._timeInMilliseconds / scalar);
        }
    }

    public static class TimeCalculation13may2024
    {
        public static ITime6apr2024 Add(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double totalMilliseconds = time1.GetInMilliseconds() + time2.GetInMilliseconds();
            return new TimeInMilliseconds6apr2024(totalMilliseconds, 0);
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

