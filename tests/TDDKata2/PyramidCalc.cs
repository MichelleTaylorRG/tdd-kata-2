namespace TDDKata2
{
    public class PyramidCalc
    {
        private const int c_unitConversionFactor = 1000;

        public double CalculateLitresNeededToFillAPyramid(int length, int width, int height)
        {
            return c_unitConversionFactor * CalculateVolumeOfAPyramid(length, width, height);
        }

        private double CalculateVolumeOfAPyramid(int length, int width, int height)
        {
            return length * width * height / 3f;
        }
    }
}