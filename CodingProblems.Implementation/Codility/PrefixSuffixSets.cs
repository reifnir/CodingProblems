using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.Implementation.Codility
{
    public class PrefixSuffixSets
    {
        public int solution(int[] A)
        {
            return GetPrefixSuffixSetCount(A);
        }

        public const int TOO_LARGE = 1000000000;

        public class NumberIndexRange
        {
            public int Number { get; set; }
            public int Range {get;set;}
        }

        public static List<NumberIndexRange> GetIndexRanges(int[] set)
        {
            var numbers = new HashSet<int>();
            var output = new List<NumberIndexRange>();
            NumberIndexRange currentNumber = null;
            int start = 0;
            for (int i = 0; i < set.Length; i++)
            {
                var n = set[i];
                if (!numbers.Contains(n))
                {
                    numbers.Add(n);

                    if (currentNumber != null)
                        currentNumber.Range = i - start;

                    start = i;
                    currentNumber = new NumberIndexRange { Number = n };
                    output.Add(currentNumber);

                }
            }
            currentNumber.Range = set.Length - start;
            return output;
        }

        public int GetPrefixSuffixSetCount(int[] set)
        {
            int output = 0;

            var prefixesNumbersUsed = new HashSet<int>();
            var suffixNumbersUsed = new HashSet<int>();

            var prefixRanges = GetIndexRanges(set);
            var suffixRanges = GetIndexRanges(set.Reverse().ToArray());

            for (int rangeIndex = 0; rangeIndex < prefixRanges.Count; rangeIndex++)
            {
                var prefixRange = prefixRanges[rangeIndex];
                var suffixRange = suffixRanges[rangeIndex];

                prefixesNumbersUsed.Add(prefixRange.Number);
                suffixNumbersUsed.Add(suffixRange.Number);

                if (prefixesNumbersUsed.SetEquals(suffixNumbersUsed))
                    output += (prefixRange.Range * suffixRange.Range);

                if (output > TOO_LARGE)
                    return TOO_LARGE;
            }
            return output;
        }
    }
}
