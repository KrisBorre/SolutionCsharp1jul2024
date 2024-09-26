namespace LibraryPhysicalUnitsChatGPT1jul2024
{
    // Additional Classes for Velocity, Length, and Acceleration Operations
    public static class PhysicalOperators
    {
        // Subtract two velocities to get acceleration multiplied by time (Δv = a * t)
        public static AccelerationInMeterPerSecondSquared17may2024 operator /(VelocityInMeterPerSecond13may2024 vDelta, TimeInSeconds8may2024 t)
        {
            double acceleration = vDelta.GetInMeterPerSecond() / t.GetInSeconds();
            return new AccelerationInMeterPerSecondSquared17may2024(acceleration);
        }

        // Add Length and Length
        public static LengthInMeter8may2024 operator +(LengthInMeter8may2024 l1, LengthInMeter8may2024 l2)
        {
            return new LengthInMeter8may2024(l1.GetInMeter() + l2.GetInMeter());
        }

        // Subtract Length and Length
        public static LengthInMeter8may2024 operator -(LengthInMeter8may2024 l1, LengthInMeter8may2024 l2)
        {
            return new LengthInMeter8may2024(l1.GetInMeter() - l2.GetInMeter());
        }

        // Add Acceleration and Acceleration
        public static AccelerationInMeterPerSecondSquared17may2024 operator +(AccelerationInMeterPerSecondSquared17may2024 a1, AccelerationInMeterPerSecondSquared17may2024 a2)
        {
            return new AccelerationInMeterPerSecondSquared17may2024(a1.GetInMeterPerSecondSquared() + a2.GetInMeterPerSecondSquared());
        }

        // Subtract Acceleration and Acceleration
        public static AccelerationInMeterPerSecondSquared17may2024 operator -(AccelerationInMeterPerSecondSquared17may2024 a1, AccelerationInMeterPerSecondSquared17may2024 a2)
        {
            return new AccelerationInMeterPerSecondSquared17may2024(a1.GetInMeterPerSecondSquared() - a2.GetInMeterPerSecondSquared());
        }

        // Add Time and Time
        public static TimeInSeconds8may2024 operator +(TimeInSeconds8may2024 t1, TimeInSeconds8may2024 t2)
        {
            return new TimeInSeconds8may2024(t1.GetInSeconds() + t2.GetInSeconds());
        }

        // Subtract Time and Time
        public static TimeInSeconds8may2024 operator -(TimeInSeconds8may2024 t1, TimeInSeconds8may2024 t2)
        {
            return new TimeInSeconds8may2024(t1.GetInSeconds() - t2.GetInSeconds());
        }
    }
}
