using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P017
    {
        public static int OneToNine()
        {
            return new int[] {
                "one".Length,
                "two".Length,
                "three".Length,
                "four".Length,
                "five".Length,
                "six".Length,
                "seven".Length,
                "eight".Length,
                "nine".Length
            }.Sum();
        }
        public static int TenToNineteen()
        {
            return new int[]
            {
                "ten".Length,
                "eleven".Length,
                "twelve".Length,
                "thirteen".Length,
                "fourteen".Length,
                "fifteen".Length,
                "sixteen".Length,
                "seventeen".Length,
                "eighteen".Length,
                "nineteen".Length
            }.Sum();
        }


        public static int TwentyToNinetyNine()
        {
            return (OneToNine() * 8)
                + (new int[] {
                "twenty".Length,
                "thirty".Length,
                "forty".Length,
                "fifty".Length,
                "sixty".Length,
                "seventy".Length,
                "eighty".Length,
                "ninety".Length
            }.Sum() * 10);
        }

        public static int OneHundredToNineHundredNinetyNine()
        {
            return (OneToNine() * 100)
                + ("hundred".Length * 100 * 9)
                + ("and".Length * 99 * 9)
                + (OneToNinetyNine() * 9);
        }

        public static int OneToNinetyNine()
        {
            return OneToNine() + TenToNineteen() + TwentyToNinetyNine();
        }

        public static int OneThousand()
        {
            return "onethousand".Length;
        }

        public static int OneToOneThousand()
        {
            return OneToNinetyNine() + OneHundredToNineHundredNinetyNine() + OneThousand();
        }
    }
}
