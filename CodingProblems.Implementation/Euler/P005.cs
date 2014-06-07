using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P005
    {
        public static int GetSmallestMultiple(int min, int max)
        {
            var primes = Common.GetPrimesLessThanN(max);
            var factors = new Dictionary<int, int>();

            for (int i = min; i <= max; i++)
            {
                var currentFactors = Common.GetPrimeFactorsAndCounts(i, primes);
                foreach (var factor in currentFactors)
                {
                    if (!factors.Keys.Contains(factor.Key))
                        factors.Add(factor.Key, factor.Value);

                    if (factors[factor.Key] < factor.Value)
                        factors[factor.Key] = factor.Value;
                }
            }
            
            int output = 1;
            foreach (var factor in factors)
            {
                output *= Convert.ToInt32(Math.Pow(factor.Key, factor.Value));
            }
            return output;
        }
    }
}
