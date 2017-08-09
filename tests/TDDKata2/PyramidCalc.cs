namespace TDDKata2
{
    public class PyramidCalc : CalcBase
    {
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