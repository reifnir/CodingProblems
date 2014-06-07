using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P023
    {
        public class AbundantSumSieve
        {
            private bool[] numbers;
            public AbundantSumSieve(int maxNumber)
            {
                LoadNumbers(maxNumber);
            }

            private void LoadNumbers(int maxNumber)
            {
                numbers = new bool[maxNumber + 1];
                for (int i = 0; i < maxNumber; i++)
                {
                    numbers[i] = IsAbundantNumber(i);
                }
            }
            public bool IsSumOfAbundantNumbers(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] && numbers[n - i])
                        return true;
                }
                return false;
            }
        }

        public static bool IsAbundantNumber(int n)
        {
            return n < Common.GetAllDivisorsOfN(n).Sum();
        }
        private const int LIMIT = 28123;
        public static int SumOfAllNonAbundantSums()
        {
            var sieve = new AbundantSumSieve(LIMIT);
            var output = 0;
            for (int i = 1; i < LIMIT; i++)
            {
                if (sieve.IsSumOfAbundantNumbers(i))
                output += i;
            }
            return output;
        }
    }
}
