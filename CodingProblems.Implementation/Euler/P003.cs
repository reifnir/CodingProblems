using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P003
    {
        public class PrimeSieve
        {
            private readonly bool[] possiblePrimes;
            public PrimeSieve(int maximumNumber)
            {
                possiblePrimes = (bool[])Array.CreateInstance(typeof(bool), maximumNumber);
            }
            public bool IsComposite(int n)
            {
                return possiblePrimes[n - 1];
            }
            public void SetComposite(int n)
            {
                possiblePrimes[n - 1] = true;
            }
        }

        public static List<int> GetPrimesUpToN(int n)
        {
            var output = new List<int>();
            var sieve = new PrimeSieve(n);
            for (int index = 2; index <= n; index++)
            {
                //If not already identified as a non-prime
                if (!sieve.IsComposite(index))
                {
                    //Add every multiple of index up to n
                    for (int multiple = 2; multiple * index <= n; multiple++)
                    {
                        sieve.SetComposite(multiple * index);
                    }
                }
            }

            for (int index = 2; index <= n; index++)
            {
                if (!sieve.IsComposite(index))
                    output.Add(index);
            }
            return output;
        }

        public static List<int> GetPrimeFactors(long n)
        {
            var primes = GetPrimesUpToN(Convert.ToInt32(Math.Sqrt(n) + 1));

            var primeFactors = primes.Where(x => n % x == 0)
                .ToList();

            return primeFactors;
        }

        public static int GetMaxPrimeFactor(long n)
        {
            return P003.GetPrimeFactors(n).Max();
        }
    }
}
