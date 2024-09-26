namespace LibraryPhysicalUnitsChatGPT1jul2024
{
    // Velocity in Meters per Second
    public class VelocityInMeterPerSecond13may2024
    {
        private double _velocityInMetersPerSecond;
        private double _tolerance;

        public VelocityInMeterPerSecond13may2024(double velocityInMetersPerSecond, double tolerance = 0)
        {
            _velocityInMetersPerSecond = velocityInMetersPerSecond;
            _tolerance = tolerance;
        }

        public double GetInMeterPerSecond()
        {
            return _velocityInMetersPerSecond;
        }

        // Operator Overloads
        public static VelocityInMeterPerSecond13may2024 operator +(VelocityInMeterPerSecond13may2024 v1, VelocityInMeterPerSecond13may2024 v2)
        {
            return new VelocityInMeterPerSecond13may2024(v1._velocityInMetersPerSecond + v2._velocityInMetersPerSecond);
        }

        public static VelocityInMeterPerSecond13may2024 operator -(VelocityInMeterPerSecond13may2024 v1, VelocityInMeterPerSecond13may2024 v2)
        {
            return new VelocityInMeterPerSecond13may2024(v1._velocityInMetersPerSecond - v2._velocityInMetersPerSecond);
        }

        public static VelocityInMeterPerSecond13may2024 operator *(VelocityInMeterPerSecond13may2024 v, double scalar)
        {
            return new VelocityInMeterPerSecond13may2024(v._velocityInMetersPerSecond * scalar);
        }

        public static VelocityInMeterPerSecond13may2024 operator *(double scalar, VelocityInMeterPerSecond13may2024 v)
        {
            return new VelocityInMeterPerSecond13may2024(v._velocityInMetersPerSecond * scalar);
        }

        public static VelocityInMeterPerSecond13may2024 operator /(VelocityInMeterPerSecond13may2024 v, double scalar)
        {
            return new VelocityInMeterPerSecond13may2024(v._velocityInMetersPerSecond / scalar);
        }

        // Divide Velocity by Acceleration to get Time
        public static TimeInSeconds8may2024 operator /(VelocityInMeterPerSecond13may2024 v, AccelerationInMeterPerSecondSquared17may2024 a)
        {
            double time = v._velocityInMetersPerSecond / a.GetInMeterPerSecondSquared();
            return new TimeInSeconds8may2024(time);
        }

        // Divide Length by Velocity to get Time
        public static TimeInSeconds8may2024 operator /(LengthInMeter8may2024 l, VelocityInMeterPerSecond13may2024 v)
        {
            double time = l.GetInMeter() / v.GetInMeterPerSecond();
            return new TimeInSeconds8may2024(time);
        }

        // Divide Velocity by Acceleration to get Time
        public static TimeInSeconds8may2024 operator /(VelocityInMeterPerSecond13may2024 v, AccelerationInMeterPerSecondSquared17may2024 a)
        {
            double time = v.GetInMeterPerSecond() / a.GetInMeterPerSecondSquared();
            return new TimeInSeconds8may2024(time);
        }

        // Divide Length by Time to get Velocity
        public static VelocityInMeterPerSecond13may2024 operator /(LengthInMeter8may2024 l, TimeInSeconds8may2024 t)
        {
            double velocity = l.GetInMeter() / t.GetInSeconds();
            return new VelocityInMeterPerSecond13may2024(velocity);
        }
    }

    // Length in Meters
    public class LengthInMeter8may2024
    {
        private double _lengthInMeters;
        private double _tolerance;

        public LengthInMeter8may2024(double lengthInMeters, double tolerance = 0)
        {
            _lengthInMeters = lengthInMeters;
            _tolerance = tolerance;
        }

        public double GetInMeter()
        {
            return _lengthInMeters;
        }

        // Operator Overloads
        public static LengthInMeter8may2024 operator +(LengthInMeter8may2024 l1, LengthInMeter8may2024 l2)
        {
            return new LengthInMeter8may2024(l1._lengthInMeters + l2._lengthInMeters);
        }

        public static LengthInMeter8may2024 operator -(LengthInMeter8may2024 l1, LengthInMeter8may2024 l2)
        {
            return new LengthInMeter8may2024(l1._lengthInMeters - l2._lengthInMeters);
        }

        public static LengthInMeter8may2024 operator *(LengthInMeter8may2024 l, double scalar)
        {
            return new LengthInMeter8may2024(l._lengthInMeters * scalar);
        }

        public static LengthInMeter8may2024 operator *(double scalar, LengthInMeter8may2024 l)
        {
            return new LengthInMeter8may2024(l._lengthInMeters * scalar);
        }

        public static LengthInMeter8may2024 operator /(LengthInMeter8may2024 l, double scalar)
        {
            return new LengthInMeter8may2024(l._lengthInMeters / scalar);
        }

        // Divide Length by Velocity to get Time
        public static TimeInSeconds8may2024 operator /(LengthInMeter8may2024 l, VelocityInMeterPerSecond13may2024 v)
        {
            double time = l.GetInMeter() / v.GetInMeterPerSecond();
            return new TimeInSeconds8may2024(time);
        }

        // Divide Length by Time to get Velocity
        public static VelocityInMeterPerSecond13may2024 operator /(LengthInMeter8may2024 l, TimeInSeconds8may2024 t)
        {
            double velocity = l.GetInMeter() / t.GetInSeconds();
            return new VelocityInMeterPerSecond13may2024(velocity);
        }
    }
}
