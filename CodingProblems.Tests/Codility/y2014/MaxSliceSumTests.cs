using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingProblems.Implementation.Codility.y2014.MaxSliceSum;

namespace CodingProblems.Tests.Codility.y2014
{
    [TestFixture]
    class MaxSliceSumTests
    {
        [Test]
        public void Soltuion_Example()
        {
            var A = new[] { 3, 2, -6, 3, 1 };
            var expected = 9;

            var actual = new Solution().solution(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetNextSlice_ExampleFirstSlice()
        {
            var A = new[] { 3, 2, -6, 3, 1 };
            var nextSliceStart = 0;
            var expected = new Solution.Slice()
            {
                MinIndex = 0,
                MaxIndex = 1,
                Sum = 5,
                SliceLength = 2,
                MaxValueInSlice = 3
            };

            var actual = Solution.GetNextSlice(A, nextSliceStart);

            Assert.IsTrue(SlicesAreEqual(expected,actual));
        }

        [Test]
        public void GetNextSlice_ExampleSecondSlice()
        {
            var A = new[] { 3, 2, -6, 3, 1 };
            var nextSliceStart = 2;

            var expected = new Solution.Slice()
            {
                MinIndex = 2,
                MaxIndex = 2,
                Sum = -6,
                SliceLength = 1,
                MaxValueInSlice = -6
            };

            var actual = Solution.GetNextSlice(A, nextSliceStart);

            Assert.IsTrue(SlicesAreEqual(expected, actual));
        }
        [Test]
        public void GetNextSlice_ExampleLastSlice()
        {
            var A = new[] { 3, 2, -6, 3, 1 };
            var nextSliceStart = 3;

            var expected = new Solution.Slice()
            {
                MinIndex = 3,
                MaxIndex = 4,
                Sum = 4,
                SliceLength = 2,
                MaxValueInSlice = 3
            };

            var actual = Solution.GetNextSlice(A, nextSliceStart);

            Assert.IsTrue(SlicesAreEqual(expected, actual));
        }

        [Test]
        public void GetNextSlice_DiminishButNotToZeroFirstSlice()
        {
            var A = new[] { 3, 2, -4, 1, 1 };
            var nextSliceStart = 0;

            var expected = new Solution.Slice()
            {
                MinIndex = 0,
                MaxIndex = 1,
                Sum = 5,
                SliceLength = 2,
                MaxValueInSlice = 3
            };

            var actual = Solution.GetNextSlice(A, nextSliceStart);

            Assert.IsTrue(SlicesAreEqual(expected, actual));
        }

        [Test]
        public void GetNextSlice_DiminishButNotToZeroSecondSlice()
        {
            var A = new[] { 3, 2, -4, 1, 1 };
            var nextSliceStart = 2;

            var expected = new Solution.Slice()
            {
                MinIndex = 2,
                MaxIndex = 2,
                Sum = -4,
                SliceLength = 1,
                MaxValueInSlice = -4
            };

            var actual = Solution.GetNextSlice(A, nextSliceStart);

            Assert.IsTrue(SlicesAreEqual(expected, actual));
        }
        [Test]
        public void GetNextSlice_DiminishButNotToZeroLastSlice()
        {
            var A = new[] { 3, 2, -4, 1, 1 };
            var nextSliceStart = 3;

            var expected = new Solution.Slice()
            {
                MinIndex = 3,
                MaxIndex = 4,
                Sum = 2,
                SliceLength = 2,
                MaxValueInSlice = 1
            };

            var actual = Solution.GetNextSlice(A, nextSliceStart);

            Assert.IsTrue(SlicesAreEqual(expected, actual));
        }

        [Test]
        public void GetNextSlice_DiminishedThenExceeded_JustOneSlice()
        {
            var A = new[] { 3, 2, -4, 3, 3 };
            var nextSliceStart = 0;

            var expected = new Solution.Slice()
            {
                MinIndex = 0,
                MaxIndex = 4,
                Sum = 7,
                SliceLength = 5,
                MaxValueInSlice = 3
            };

            var actual = Solution.GetNextSlice(A, nextSliceStart);

            Assert.IsTrue(SlicesAreEqual(expected, actual));
        }

        [Test]
        public void CutIntoSlices_Example()
        {
            var A = new[] { 3, 2, -6, 3, 1 };
            var expected = new List<Solution.Slice>()
            {
                new Solution.Slice()
                {
                    MinIndex = 0,
                    MaxIndex = 1,
                    Sum = 5,
                    SliceLength = 2,
                    MaxValueInSlice = 3
                },
                new Solution.Slice()
                {
                    MinIndex = 2,
                    MaxIndex = 2,
                    Sum = -6,
                    SliceLength = 1,
                    MaxValueInSlice = -6
                },
                new Solution.Slice()
                {
                    MinIndex = 3,
                    MaxIndex = 4,
                    Sum = 4,
                    SliceLength = 2,
                    MaxValueInSlice = 3
                },
            };

            var actual = Solution.CutIntoSlices(A).Slices;

            Assert.AreEqual(expected.Count, actual.Count);
            Assert.IsTrue(SlicesAreEqual(expected[0], actual[0]));
            Assert.IsTrue(SlicesAreEqual(expected[1], actual[1]));
            Assert.IsTrue(SlicesAreEqual(expected[2], actual[2]));
        }


        private static bool SlicesAreEqual(Solution.Slice a, Solution.Slice b)
        {
            return a.MinIndex == b.MinIndex
                && a.MaxIndex == b.MaxIndex
                && a.Sum == b.Sum
                && a.SliceLength == b.SliceLength
                && a.MaxValueInSlice == b.MaxValueInSlice;
        }




    }
}
