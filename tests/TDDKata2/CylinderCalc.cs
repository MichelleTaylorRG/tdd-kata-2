namespace TDDKata2
{
    public class CylinderCalc
    {
        private const double c_pi = 3.14;
        private const int c_unitConversionFactor = 1000;

        public double CalculateLitersNeededToFillCylinder(int radius, int height)
        {
            return CalculateVolumeOfACylinder(radius, height) * c_unitConversionFactor;
        }

        private double CalculateVolumeOfACylinder(int radius, int height)
        {
            return c_pi * radius * radius * height;
        }
    }
}