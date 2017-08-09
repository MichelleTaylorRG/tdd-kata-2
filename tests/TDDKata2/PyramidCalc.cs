namespace TDDKata2
{
    public class PyramidCalc
    {
        private const int c_unitConversionFactor = 1000;

        public static double CalculateLitresNeededToFillAPyramid(int length, int width, int height)
        {
            return c_unitConversionFactor * CalculateVolumeOfAPyramid(length, width, height);
        }

        private static double CalculateVolumeOfAPyramid(int length, int width, int height)
        {
            return length * width * height / 3f;
        }
    }
}