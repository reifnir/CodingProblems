using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P009
    {
        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }

        public static List<int> FindPythagoreanTripletTotallingN(int n)
        {
            var maxPossibleNumber = n - 3;
            for (int a = 1; a < maxPossibleNumber; a++)
            {
                for (int b = a + 1; b < n - a; b++)
                {
                    var c = n - a - b;
                    if (IsPythagoreanTriplet(a, b, c))
                        return new List<int>() { a, b, c };

                }
            }
            return new List<int>();
        }
    }
}
