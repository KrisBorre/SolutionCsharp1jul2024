namespace LibraryPhysicalUnitsChatGPT1jul2024
{
    // Acceleration in Meters per Second Squared
    public class AccelerationInMeterPerSecondSquared17may2024
    {
        private double _accelerationInMetersPerSecondSquared;
        private double _tolerance;

        public AccelerationInMeterPerSecondSquared17may2024(double accelerationInMetersPerSecondSquared, double tolerance = 0)
        {
            _accelerationInMetersPerSecondSquared = accelerationInMetersPerSecondSquared;
            _tolerance = tolerance;
        }

        public double GetInMeterPerSecondSquared()
        {
            return _accelerationInMetersPerSecondSquared;
        }

        // Operator Overloads
        public static AccelerationInMeterPerSecondSquared17may2024 operator +(AccelerationInMeterPerSecondSquared17may2024 a1, AccelerationInMeterPerSecondSquared17may2024 a2)
        {
            return new AccelerationInMeterPerSecondSquared17may2024(a1._accelerationInMetersPerSecondSquared + a2._accelerationInMetersPerSecondSquared);
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator -(AccelerationInMeterPerSecondSquared17may2024 a1, AccelerationInMeterPerSecondSquared17may2024 a2)
        {
            return new AccelerationInMeterPerSecondSquared17may2024(a1._accelerationInMetersPerSecondSquared - a2._accelerationInMetersPerSecondSquared);
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator *(AccelerationInMeterPerSecondSquared17may2024 a, double scalar)
        {
            return new AccelerationInMeterPerSecondSquared17may2024(a._accelerationInMetersPerSecondSquared * scalar);
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator *(double scalar, AccelerationInMeterPerSecondSquared17may2024 a)
        {
            return new AccelerationInMeterPerSecondSquared17may2024(a._accelerationInMetersPerSecondSquared * scalar);
        }

        public static AccelerationInMeterPerSecondSquared17may2024 operator /(AccelerationInMeterPerSecondSquared17may2024 a, double scalar)
        {
            return new AccelerationInMeterPerSecondSquared17may2024(a._accelerationInMetersPerSecondSquared / scalar);
        }

        // Multiply Acceleration by Time squared to get Length (a * t^2)
        public static LengthInMeter8may2024 operator *(AccelerationInMeterPerSecondSquared17may2024 a, double scalar)
        {
            double length = a._accelerationInMetersPerSecondSquared * scalar;
            return new LengthInMeter8may2024(length);
        }

        public static LengthInMeter8may2024 operator *(double scalar, AccelerationInMeterPerSecondSquared17may2024 a)
        {
            double length = a._accelerationInMetersPerSecondSquared * scalar;
            return new LengthInMeter8may2024(length);
        }

        // Multiply Acceleration by Time to get Velocity
        public static VelocityInMeterPerSecond13may2024 operator *(AccelerationInMeterPerSecondSquared17may2024 a, TimeInSeconds8may2024 t)
        {
            double velocity = a._accelerationInMetersPerSecondSquared * t.GetInSeconds();
            return new VelocityInMeterPerSecond13may2024(velocity);
        }

        public static VelocityInMeterPerSecond13may2024 operator *(TimeInSeconds8may2024 t, AccelerationInMeterPerSecondSquared17may2024 a)
        {
            double velocity = a._accelerationInMetersPerSecondSquared * t.GetInSeconds();
            return new VelocityInMeterPerSecond13may2024(velocity);
        }
    }
}
