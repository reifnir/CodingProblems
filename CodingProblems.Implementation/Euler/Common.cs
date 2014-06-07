using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Implementation.Euler
{
    public static class Common
    {
        public static List<int> GetPrimesLessThanN(int n)
        {
            return P003.GetPrimesUpToN(n);
        }

        /*public static List<long> GetPrimesLessThanN(this int n)
        {
            return P003.GetPrimesUpToN(n).Select(x => (int)x).ToList();
        }*/

        public static Dictionary<int, int> GetPrimeFactorsAndCounts(int n)
        {
            return GetPrimeFactorsAndCounts(n, GetPrimesLessThanN(n));
        }
        public static Dictionary<int, int> GetPrimeFactorsAndCounts(int n, List<int> primes)
        {
            var output = new Dictionary<int, int>();
            var remaining = n;

            while (remaining > 1)
            {
                primes
                    .Where(x => remaining % x == 0)
                    .ToList()
                    .ForEach(x =>
                    {
                        if (output.Keys.Contains(x))
                            output[x]++;
                        else
                            output.Add(x, 1);

                        remaining /= x;
                    });
            }

            return output;
        }

        public static BigInteger Factorial(int n)
        {
            var output = new BigInteger(1);
            for (BigInteger i = 1; i <= n; i++)
            {
                output *= i;
            }
            return output;
        }

        public static HashSet<int> GetAllDivisorsOfN(int n)
        {
            var divisors = new HashSet<int>();
            divisors.Add(1);
            var maxPossible = Math.Sqrt(n);
            for (int i = 2; i <= maxPossible; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    divisors.Add(n / i);
                }
            }
            return divisors;
        }
    }
}
