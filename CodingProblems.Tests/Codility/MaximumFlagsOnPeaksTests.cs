using CodingProblems.Implementation.Codility.MaximumFlagsOnPeaks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Tests.Codility
{
    [TestFixture]
    public class MaximumFlagsOnPeaksTests
    {
        [Test]
        public void GetMaximumFlags_Example()
        {
            var peaks = new List<int> { 1, 3, 5, 10 };
            var expected = 3;

            var actual = Solution.GetMaximumFlags(peaks);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void MaximumPeaksTests_Example()
        {
            var numbers = new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            var expected = 3;

            var actual = new Solution().solution(numbers);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetPeaks_Example()
        {
            var numbers = new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            var expected = new int[] { 1, 3, 5, 10 };

            var actual = Solution.GetPeaks(numbers);

            Assert.AreEqual(expected, actual);
        }

    }
}
