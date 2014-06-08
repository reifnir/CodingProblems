//using System;
//using System.Collections.Generic;

//namespace CodingProblems.Tests.y2013.Codility
//{
//    public class Solution
//    {
//        public const int BORDER_NOT_FOUND_LENGTH = 0;

//        public int solution(string S)
//        {
//            return GetMaxBorderLength(S, 3);
//        }

//        private int GetMaxBorderLength(string S, int minimumNonOverlappingOccurrences)
//        {
//            var largestPossibleBorder = S.Length / minimumNonOverlappingOccurrences;

//            for (int length = largestPossibleBorder; length >= 0; length--)
//            {
//                var prefix = Left(S, length);
//                var suffix = Right(S, length);
//                var inputWithoutBorders = RemoveLeadingAndTrailingCharacters(S, length);
//                if (prefix == suffix
//                    && !InstanceOfBorderOverlapsWithPrefix(prefix, S)
//                    && !InstanceOfBorderOverlapsWithSuffix(prefix, S)
//                    && OccurrsWithoutOverlappingAtLeastNTimes(prefix, RemoveLeadingAndTrailingCharacters(S, length), minimumNonOverlappingOccurrences - 2))
//                    return length;
//            }
//            return BORDER_NOT_FOUND_LENGTH;
//        }



//        private static bool OccurrsWithoutOverlappingAtLeastNTimes(string border, string S, int minimumNonOverlappingOccurrences)
//    {
//        if (minimumNonOverlappingOccurrences > 1)
//            return true;

//        var nextInstanceOfMatch = S.IndexOf(border);

//        if (nextInstanceOfMatch < 0)
//            return false;

//        var stringFromMatchOn = S.Substring(nextInstanceOfMatch);
//        if (InstanceOfBorderOverlapsWithPrefix(border, stringFromMatchOn))
//        {
//            var stringFromNextPossibleMatchOn
//        }
//        else
//        {
//        }
        


//        return InstanceOccursBetweenPrefixAndSuffix(border, S);
//    }

//        public static bool InstanceOccursBetweenPrefixAndSuffix(string border, string S)
//        {
//            var indexOfSuffixStart = S.Length - border.Length - 1;
//            return S.IndexOf(border, border.Length) < indexOfSuffixStart;
//        }

//        public static bool InstanceOfBorderOverlapsWithSuffix(string border, string S)
//        {
//            var numberOfCharactersToGet = (border.Length - 1) * 2;
//            var charactersWithPossibleOverlap = S.Substring(S.Length - numberOfCharactersToGet - 1, numberOfCharactersToGet);
//            return charactersWithPossibleOverlap.Contains(border);
//        }

//        public static bool InstanceOfBorderOverlapsWithPrefix(string border, string S)
//        {
//            var numberOfCharactersToGet = (border.Length - 1) * 2;
//            var charactersWithPossibleOverlap = S.Substring(1, numberOfCharactersToGet);
//            return charactersWithPossibleOverlap.Contains(border);
//        }

//        public static string Left(string S, int numberOfCharacters)
//        {
//            return S.Substring(0, numberOfCharacters);
//        }
//        public static string Right(string S, int numberOfCharacters)
//        {
//            return S.Substring(S.Length - numberOfCharacters);
//        }
//        public static string RemoveLeadingAndTrailingCharacters(string S, int length)
//        {
//            return S.Substring(length, S.Length - (2 * length));
//        }
//    }
//}