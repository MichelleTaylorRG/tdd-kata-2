using FluentAssertions;
using NUnit.Framework;

namespace TDDKata2
{
    [TestFixture]
    public class CylinderTests
    {
        const double PI = 3.14;

        [TestCase(1, 1, 3140)]
        [TestCase(10, 10, 3140000)]
        public void CanCalculateLitersNeededToFillACylinder(int radius, int height, double expectedAmountOfWater)
        {
            var amountOfWater = CalculateLitersNeededToFillCylinder(radius, height);
            amountOfWater.Should().Be(expectedAmountOfWater);
        }

        private static double CalculateLitersNeededToFillCylinder(int radius, int height)
        {
            return CalculateVolumeOfACylinder(radius, height) * 1000;
        }

        private static double CalculateVolumeOfACylinder(int radius, int height)
        {
            return PI * radius * radius * height;
        }
    }
}
