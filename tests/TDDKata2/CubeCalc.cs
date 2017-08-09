﻿using FluentAssertions;
using NUnit.Framework;

namespace TDDKata2
{
    class CubeCalc
    {
        private const int c_unitConversionFactor = 1000;

        public static double CalculateLitersNeededToFill(int sideInMeters)
        {
            return c_unitConversionFactor * CalculateVolumeOfACube(sideInMeters);
        }

        private static double CalculateVolumeOfACube(int sideInMeters)
        {
            return sideInMeters * sideInMeters * sideInMeters;
        }
    }
}