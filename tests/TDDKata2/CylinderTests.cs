using FluentAssertions;
using NUnit.Framework;

namespace TDDKata2
{
    [TestFixture]
    public class CylinderTests
    {
        [TestCase(1, 1, 3140)]
        [TestCase(10, 10, 3140000)]
        public void CanCalculateLitersNeededToFillACylinder(int radius, int height, double expectedAmountOfWater)
        {
            var calc = new CylinderCalc();
            var amountOfWater = calc.CalculateLitersNeededToFillCylinder(radius, height);
            amountOfWater.Should().Be(expectedAmountOfWater);
        }
    }
}
