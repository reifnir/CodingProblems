using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CodingProblems.Implementation.Euler
{
    public class P016
    {
        public static int SumOfNumberPowerDigits(int n, int exponent)
        {
            var bigNumber = BigInteger.Pow(n, exponent);

            return bigNumber
                .ToString()
                .Select(x => int.Parse(x.ToString()))
                .Sum();
        }
    }
}
