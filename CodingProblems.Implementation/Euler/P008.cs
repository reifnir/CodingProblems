using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P008
    {
        public static int FindProductOfConsecutiveNumbers(string series, int numberOccuringInARow)
        {
            int output = 0;
            var firstCharacterOfLastSeries = series.Length - numberOccuringInARow + 1;

            for (int startOfSeries = 0; startOfSeries < firstCharacterOfLastSeries; startOfSeries++)
            {
                var currentSequence = series.Substring(startOfSeries, numberOccuringInARow);
                var product = 1;
                currentSequence.Select(x => int.Parse(x.ToString())).ToList().ForEach(x => product *= x);

                if (product > output)
                    output = product;
            }
            return output;
        }
    }
}
