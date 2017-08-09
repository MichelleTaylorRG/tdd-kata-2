namespace TDDKata2
{
    public class CylinderCalc : CalcBase
    {
        private const double c_pi = 3.14;

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