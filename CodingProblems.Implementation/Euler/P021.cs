using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P021
    {
        public static bool IsAmicableNumber(int n)
        {
            return SumOfDivisors(SumOfDivisors(n)) == n;
        }
        public static int SumOfDivisors(int n)
        {
            var divisors = Common.GetAllDivisorsOfN(n);
            return divisors.Sum();
        }

        public static int SumOfAllAmicableNumbersUnderN(int n)
        {
            var numbers = Enumerable.Range(1, n - 1).ToList();
            var pairs = (
                from num in numbers
                let sumOfNDivisors = SumOfDivisors(num)
                let sumOfAmicablePairDivisors = SumOfDivisors(sumOfNDivisors)
                where num == sumOfAmicablePairDivisors
                && num != sumOfNDivisors
                select new { N = num, Pair = sumOfNDivisors }
                ).ToList();

            return pairs.Sum(x => x.N);

        }
    }
}
