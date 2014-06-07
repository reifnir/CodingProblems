using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P012
    {
        public static IEnumerable<int> GetTriangleNumbers(int numberOfTriangleNumbersToReturn)
        {
            var triangleGenerator = new P012();
            for (int i = 1; i <= numberOfTriangleNumbersToReturn; i++)
            {
                yield return triangleGenerator.GetNextTriangleNumber();
            }
        }

        public int GetFirstTriangleNumberWithAtLeastNDivisors(int n)
        {
            int triangle = 0;
            int numberOfDivisors = 0;
            while (numberOfDivisors < n)
            {
                triangle = GetNextTriangleNumber();
                numberOfDivisors = NumberOfDivisors(triangle);
            }
            return triangle;
        }

        private static int NumberOfDivisors(int triangle)
        {
            var numberOfDivisors = Common.GetAllDivisorsOfN(triangle).Count;
            return numberOfDivisors;
        }

        int triangleNumber = 0;
        int triangleIndex = 0;
        public int GetNextTriangleNumber()
        {
            triangleIndex++;
            triangleNumber += triangleIndex;
            return triangleNumber;
        }
    }
}
