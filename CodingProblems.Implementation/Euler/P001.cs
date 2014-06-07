using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    //Multiples of 3 and 5
    public class P001
    {
        public int SumOfMultiplesOfThreeAndFive(int intervalStart, int intervalEnd)
        {
            int result = 0;
            for (int index = intervalStart; index <= intervalEnd; index++)
            {
                if (index % 3 == 0 || index % 5 == 0)
                    result += index;
            }
            return result;
        }
    }
}
