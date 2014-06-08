//Namespace outside of the using statements so that the guts can simply
//be pasted into Codility's window after testing
namespace CodingProblems.Implementation.Codility.y2013.MaximumFlagsOnPeaks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int solution(int[] A)
        {
            var peaks = GetPeaks(A);
            var maximumFlags = GetMaximumFlags(peaks);
            return maximumFlags;
        }

        //Brute force O(N^2 solution), it's just a start...        
        /*internal static int GetMaximumFlags(List<int> peaks)
        {
            var maxSupportedFlags = 0;

            for (int i = 1; i < peaks.Count; i++)
            {
                if (CanSupportNFlags(peaks, i))
                    maxSupportedFlags = i;
                else
                    //No reason to continue
                    break;
            }
            return maxSupportedFlags;
        }*/

        //O(Log(N) solution), getting better
        //Would be more concise if C# supported tail recursion...
        internal static int GetMaximumFlags(List<int> peaks)
        {
            if (peaks.Count == 0)
                return 0;

            var minPeaksPossible = 1;
            var maxPeaksPossible = peaks.Count;

            while (minPeaksPossible != maxPeaksPossible)
            {
                var nextNumberToCheck = 1 + (minPeaksPossible + maxPeaksPossible) / 2;

                if (CanSupportNFlags(peaks, nextNumberToCheck))
                    minPeaksPossible = nextNumberToCheck;
                else
                    maxPeaksPossible = nextNumberToCheck - 1;
            }

            return minPeaksPossible;
        }
        
        private static bool CanSupportNFlags(List<int> peaks, int n)
        {
            var supportedPeaks = 0;
            int lastPeak = 0;
            Func<int,int> SpaceSinceLastPeak = (x) => x - lastPeak;

            foreach (var peak in peaks)
            {

                if (IsFirstPeak(peaks, peak) || (SpaceSinceLastPeak(peak) >= n))
                {
                    supportedPeaks++;
                    lastPeak = peak;
                }

                if (supportedPeaks == n)
                    break;
            }

            return (supportedPeaks == n);
        }

        private static bool IsFirstPeak(List<int> peaks, int peak)
        {
            return peak == peaks[0];
        }

        internal static List<int> GetPeaks(int[] numbers)
        {
            var maxPossiblePeak = numbers.Length - 1;
            var output = new List<int>();

            for (int i = 1; i < maxPossiblePeak; i++)
            {
                if (IsPeak(i, numbers))
                    output.Add(i);
            }
            return output;
        }

        private static bool IsPeak(int i, int[] numbers)
        {
            var prior = numbers[i - 1];
            var current = numbers[i];
            var next = numbers[i + 1];

            return prior < current && current > next;
        }
    }
}
