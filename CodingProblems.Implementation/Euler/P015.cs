using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CodingProblems.Implementation.Euler
{
    public class P015
    {
        public static BigInteger RoutesThroughGrid(int x, int y)
        {
            Func<int, int, BigInteger> Choose = (n, k) => Common.Factorial(n) / Common.Factorial(k) / Common.Factorial(n - k);

            return Choose(x + y, x);
        }
        /*public static double RoutesThroughGrid(int x, int y)
        {
            var factorsOfX = GetFactorialFactors(x);
            var factorsOfY = GetFactorialFactors(y);
            var factorsOfXPlusY = GetFactorialFactors(x + y);

            var resultingFactors = SubtractFactors(factorsOfXPlusY, factorsOfX);
            resultingFactors = SubtractFactors(resultingFactors, factorsOfY);

            return MultiplyFactors(resultingFactors);

        }

        private static double MultiplyFactors(Dictionary<int, int> factors)
        {
            var output = 1d;

            foreach (var item in factors)
            {
                var oldOutput = output;
                output *= Math.Pow(item.Key, item.Value);

                if (output < oldOutput)
                    throw new OverflowException();
            }
            return output;
        }

        private static Dictionary<int, int> SubtractFactors(Dictionary<int, int> a, Dictionary<int, int> b)
        {
            var output = new Dictionary<int, int>(a);

            foreach (var item in b)
            {
                if (output.Keys.Contains(item.Key))
                    output[item.Key] -= item.Value;
                else
                    output.Add(item.Key, -item.Value);                
            }
            return output;
        }

        


        private static Dictionary<int, int> GetFactorialFactors(int n)
        {
            var factors = new Dictionary<int, int>();

            for (int i = 2; i <= n; i++)
            {
                var iFactors = Common.GetPrimeFactorsAndCounts(i);

                foreach (var factor in iFactors)
                {
                    if (factors.Keys.Contains(factor.Key))
                        factors[factor.Key] += factor.Value;
                    else
                        factors.Add(factor.Key, factor.Value);
                }

            }

            return factors;
        }*/
    }
}
