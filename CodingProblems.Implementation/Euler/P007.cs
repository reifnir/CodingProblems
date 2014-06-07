using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P007
    {
        public static int GetNthPrimeNumber(int n)
        {
            var primes = Common.GetPrimesLessThanN(150000);
            return primes[n - 1];
        }

    }
}
