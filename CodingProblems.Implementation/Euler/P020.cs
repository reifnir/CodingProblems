using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P020
    {
        public static int FactorialDigitSum(int n)
        {
            var factorialValue = Common.Factorial(n);
            return factorialValue
                .ToString()
                .Select(x => int.Parse(x.ToString()))
                .Sum();
        }
    }
}
