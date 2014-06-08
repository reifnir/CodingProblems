namespace CodingProblems.Implementation.Codility.y2013.PairsOfClockFaces
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public int solution(int[][] A, int P)
        {

            //this is a list of example linked lists with the count of found items
            var sets = new Dictionary<string, int>();

            //for each set of numbers
            for (int setIndex = 0; setIndex < A.Length; setIndex++)
            {
                var set = A[setIndex];
                var setAsString = GetSetKey(set, P);

                var matchingSet = FindMatchingSet(sets, setAsString);

                if (matchingSet == null)
                    sets.Add(string.Format("{0},{0}", setAsString), 1);
                else
                    sets[matchingSet]++;
            }

            var result = GetSumOfPairs(sets);

            return result;
        }

        private int GetSumOfPairs(Dictionary<string, int> sets)
        {
            var output = 0;

            foreach (var value in sets.Values)
            {
                output += SumOfNumbersLessThanN(value);
            }
            return output;
        }

        private static int SumOfNumbersLessThanN(int n)
        {
            return n > 1
                ? n * (n - 1) / 2
                : 0;
        }

        private string FindMatchingSet(Dictionary<string, int> sets, string set)
        {
            string matchingSet = null;
            foreach (var setToCompare in sets.Keys)
            {
                if (/*setToCompare.Length == (2 * set.Length) &&*/ setToCompare.IndexOf(set) >= 0)
                {
                    matchingSet = setToCompare;
                    break;
                }
            }

            return matchingSet;
        }

        public static string GetSetKey(int[] set, int p)
        {
            Array.Sort(set);
            var sb = new System.Text.StringBuilder();

            int lastValue = set[set.Length - 1];
            
            var numbers = new string[set.Length];

            for (int index = 0; index < set.Length; index++)
            {
                var currentValue = set[index];

                //sb.Append(GetDifferneceBetweenTwoPoints(lastValue, currentValue, p).ToString());
                //sb.Append(',');

                numbers[index] = GetDifferneceBetweenTwoPoints(lastValue, currentValue, p).ToString();

                lastValue = currentValue;
            }
            return string.Join(",", numbers);
        }
        
        private static int GetDifferneceBetweenTwoPoints(int currentValue, int nextValue, int p)
        {
            if (nextValue > currentValue)
                return nextValue - currentValue;

            return p - currentValue + nextValue;
        }
    }
}