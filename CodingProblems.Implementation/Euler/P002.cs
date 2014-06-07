using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P002
    {
        //Even Fibonacci numbers
        public int SumOfEvenFibonacciNumbersLessThanN(int maximum)
        {
            var fibonacciLast = 1;
            var fibonacciCurrent = 1;
            //var isEven = false;
            var sum = 0;

            while (fibonacciCurrent < maximum)
            {
                var fibonacciNext = fibonacciLast + fibonacciCurrent;
                //isEven = !isEven;

                if (fibonacciNext < maximum && fibonacciNext % 2 == 0)
                    sum += fibonacciNext;

                fibonacciLast = fibonacciCurrent;
                fibonacciCurrent = fibonacciNext;
            }
            return sum;
        }
    }
}
