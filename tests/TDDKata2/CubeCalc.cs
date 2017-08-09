using FluentAssertions;
using NUnit.Framework;

namespace TDDKata2
{
    class CubeCalc : CalcBase
    {
        public double CalculateLitersNeededToFill(int sideInMeters)
        {
            return c_unitConversionFactor * CalculateVolumeOfACube(sideInMeters);
        }

        private double CalculateVolumeOfACube(int sideInMeters)
        {
            return sideInMeters * sideInMeters * sideInMeters;
        }
    }
}