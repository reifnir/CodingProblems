using CodingProblems.Implementation.Codility.y2013.PairsOfClockFaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CodingProblems.Tests.Codility.y2013
{
    [TestFixture]
    public class PairsOfClockFacesTests
    {
        [Test]
        public void solution_FailedTest_ReturnsExpectedNumber()
        {
            var p = 24;
            int[][] numbers = new int[][] {
                new int[] { 7, 16, 20, 24 },
                new int[] { 5, 14, 18, 22 },
                new int[] { 6, 7, 10, 15 },
                new int[] { 6, 7, 10, 15 },
                new int[] { 3, 7, 11, 18 },
                new int[] { 4, 8, 12, 19 }
            };
            var expected = 7;

            var actual = new Solution().solution(numbers, p);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void solution_ExampleNumbers_ReturnsExpectedNumber()
        {
            var p = 4;

            int[][] numbers = new int[][] {
                new int[] {1, 2},
                new int[] {2, 4},
                new int[] {4, 3},
                new int[] {2, 3},
                new int[] {1, 3}
            };
            var expected = 4;

            var actual = new Solution().solution(numbers, p);

            Assert.AreEqual(expected, actual);
        }
    }
}
