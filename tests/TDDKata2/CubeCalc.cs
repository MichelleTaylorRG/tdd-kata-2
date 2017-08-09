using FluentAssertions;
using NUnit.Framework;

namespace TDDKata2
{
    class CubeCalc
    {
        public static double CalculateLitersNeededToFill(int sideInMeters)
        {
            return 1000 * CalculateVolumeOfACube(sideInMeters);
        }

        private static double CalculateVolumeOfACube(int sideInMeters)
        {
            return sideInMeters * sideInMeters * sideInMeters;
        }
    }
}