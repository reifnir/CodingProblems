using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P022
    {

        public static int GetNameValueForPosition(string name, int indexOfName)
        {
            return GetNameValue(name) * (indexOfName + 1);
        }
        public static int GetNameValue(string name)
        {
            var nameValue = name
                .Select(LetterOrdinal)
                .Sum();
            return nameValue;
        }

        private static int LetterOrdinal(char c)
        {
            //one-based capital letter ordinal
            return c - 'A' + 1;
        }

        public static int GetSumOfNameValuesByPosition(string names)
        {
            var sum = names.Split(',')
                .OrderBy(x => x)
                .Select(TrimQuotes)
                .Select(GetNameValueForPosition)
                .Sum();
            return sum;
        }
        public static string TrimQuotes(string s)
        {
            return s.Trim('"');
        }
    }
}
