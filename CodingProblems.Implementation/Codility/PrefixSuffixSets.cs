namespace CodingProblems.Implementation.Codility.PrefixSuffixSets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
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

        public class PrefixSuffixRanges
        {
            public NumberIndexRange Prefix { get; set; }
            public NumberIndexRange Suffix { get; set; }
        }
        public static IEnumerable<PrefixSuffixRanges> GetPrefixSuffixIndexRanges(int[] set)
        {
            var prefixRanges = GetIndexRanges(set);
            var suffixRanges = GetIndexRanges(set.Reverse().ToArray());

            var prefixEnumerator = prefixRanges.GetEnumerator();
            var suffixEnumerator = suffixRanges.GetEnumerator();

            while (prefixEnumerator.MoveNext() && suffixEnumerator.MoveNext())
            {
                yield return new PrefixSuffixRanges
                {
                    Prefix = prefixEnumerator.Current,
                    Suffix = suffixEnumerator.Current
                };
            }
        }

        public static IEnumerable<NumberIndexRange> GetIndexRanges(int[] set)
        {
            var numbers = new HashSet<int>();
            NumberIndexRange currentNumber = null;
            int start = 0;
            for (int i = 0; i < set.Length; i++)
            {
                var n = set[i];
                if (!numbers.Contains(n))
                {
                    numbers.Add(n);

                    if (currentNumber != null)
                    {
                        currentNumber.Range = i - start;
                        yield return currentNumber;
                    }

                    start = i;
                    currentNumber = new NumberIndexRange { Number = n };
                }
            }
            currentNumber.Range = set.Length - start;
            yield return currentNumber;
        }

        public int GetPrefixSuffixSetCount(int[] set)
        {
            int output = 0;

            var prefixesNumbersUsed = new HashSet<int>();
            var suffixNumbersUsed = new HashSet<int>();
            var lastPrefixUsed = int.MinValue;
            var lastSuffixUsed = int.MinValue;

            foreach (var rangePair in GetPrefixSuffixIndexRanges(set))
            {
                var prefixRange = rangePair.Prefix;
                var suffixRange = rangePair.Suffix;

                prefixesNumbersUsed.Add(prefixRange.Number);
                suffixNumbersUsed.Add(suffixRange.Number);

                if (prefixesNumbersUsed.SetEquals(suffixNumbersUsed))
                {
                    //No need to keep comparing values that worked already
                    prefixesNumbersUsed.Clear();
                    suffixNumbersUsed.Clear();
                    output += (prefixRange.Range * suffixRange.Range);
                }

                if (output > TOO_LARGE)
                    return TOO_LARGE;                
            }

            return output;
        }
    }
}
