namespace TDDKata2
{
    public class CylinderCalc
    {
        private const double c_pi = 3.14;

        public static double CalculateLitersNeededToFillCylinder(int radius, int height)
        {
            return CalculateVolumeOfACylinder(radius, height) * 1000;
        }

        private static double CalculateVolumeOfACylinder(int radius, int height)
        {
            return c_pi * radius * radius * height;
        }
    }
}