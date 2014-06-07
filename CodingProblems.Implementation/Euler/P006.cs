using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P006
    {
        public static int SquareOfSums(int min, int max)
        {
            var sum = Enumerable.Range(min, 1 + max - min).Sum();
            return sum * sum;
        }

        public static int SumOfSquares(int min, int max)
        {
            return Enumerable.Range(min, 1 + max - min).Select(x => x * x).Sum();
        }

        public static int SumSquareDifference(int min, int max)
        {
            return SquareOfSums(min, max) - SumOfSquares(min, max);
        }
    }
}
