using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P010
    {
        public static long SumOfPrimesLessThanN(int n)
        {
            return Common.GetPrimesLessThanN(n).Select(x => (long)x).Sum();
        }
    }
}
