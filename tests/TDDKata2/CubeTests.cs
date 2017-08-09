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
            var amountOfWater = CubeCalc.CalculateLitersNeededToFill(side);
            amountOfWater.Should().Be(expectedLitres);
        }
    }
}
