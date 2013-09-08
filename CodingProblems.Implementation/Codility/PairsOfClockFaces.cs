using System;
using System.Collections.Generic;
public class PairsOfClockFaces
{
    public int solution(int[][] A, int P)
    {

        //this is a list of example linked lists as well as the count of found items
        var sets = new Dictionary<string, int>();

        //for each set of numbers
        for (int setIndex = 0; setIndex < A.Length; setIndex++)
        {
            var set = A[setIndex];
            var setAsString = GetSetKey(set, P);

            var matchingSet = FindMatchingSet(sets, setAsString);

            if (matchingSet == null)
                sets.Add(string.Format("{0}{0}", setAsString), 1);
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
            if (setToCompare.Length == (2 * set.Length) && setToCompare.Contains(set))
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

        for (int index = 0; index < set.Length; index++)
        {
            var currentValue = set[index];

            //Gets next item or first item (when on the last one)
            var nextValue = index + 1 == set.Length
                ? set[0]
                : set[index + 1];
            sb.Append(GetDifferneceBetweenTwoPoints(currentValue, nextValue, p).ToString());
            sb.Append(',');
            //output[index] = GetDifferneceBetweenTwoPoints(currentValue, nextValue, p).ToString();
        }
        return sb.ToString();
    }

    private static int GetDifferneceBetweenTwoPoints(int currentValue, int nextValue, int p)
    {
        if (nextValue > currentValue)
            return nextValue - currentValue;

        return p - currentValue + nextValue;
    }
}
