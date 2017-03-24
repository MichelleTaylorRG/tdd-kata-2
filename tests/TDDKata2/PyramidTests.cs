﻿using FluentAssertions;
using NUnit.Framework;

namespace TDDKata2
{
    [TestFixture]
    public class PyramidTests
    {
        [TestCase(1, 1, 1, 333)]
        [TestCase(3, 10, 10, 100000)]
        public void CanCalculateLitresNeededToFillAPyramid(int length, int width, int height, double expectedAmountOfWater)
        {
            var amountOfWater = CalculateLitresNeededToFillAPyramid(length, width, height);
            amountOfWater.Should().BeApproximately(expectedAmountOfWater, 1);
        }

        private static double CalculateLitresNeededToFillAPyramid(int length, int width, int height)
        {
            return 1000 * CalculateVolumeOfAPyramid(length, width, height);
        }

        private static double CalculateVolumeOfAPyramid(int length, int width, int height)
        {
            return length * width * height / 3f;
        }
    }
}