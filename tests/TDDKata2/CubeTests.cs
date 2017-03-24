using FluentAssertions;
using NUnit.Framework;

namespace TDDKata2
{
    [TestFixture]
    class CubeTests
    {
        [TestCase(1, 1000)]
        [TestCase(2, 8000)]
        public void CanCalculateLitersNeededToFillACube(int side, double expectedLitres)
        {
            var amountOfWater = CalculateLitersNeededToFill(side);
            amountOfWater.Should().Be(expectedLitres);
        }

        private static double CalculateLitersNeededToFill(int sideInMeters)
        {
            return 1000 * CalculateVolumeOfACube(sideInMeters);
        }

        private static double CalculateVolumeOfACube(int sideInMeters)
        {
            return sideInMeters * sideInMeters * sideInMeters;
        }
    }
}
