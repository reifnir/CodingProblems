using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P013
    {
        public static string SumOfVeryLargeNumber(string[] numbers, int leftMostDigitsToReturn)
        {
            double sum = 0;

            foreach (var number in numbers)
            {
                var value = double.Parse(number);
                sum += value;
            }
            var fullOutput = sum.ToString("0");
            return fullOutput.Substring(0, leftMostDigitsToReturn);
        }
    }
}
