using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P006Tests
    {
        [Test]
        public void SumOfSquares_1To10_385()
        {
            var expected = 385;
            var actual = P006.SumOfSquares(1, 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SquareOfSums_1To10_3025()
        {
            var expected = 3025;
            var actual = P006.SquareOfSums(1, 10);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SumSquareDifference_1To10_2640()
        {
            var expected = 2640;
            var actual = P006.SumSquareDifference(1, 10);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SumSquareDifference_1To100_2640()
        {
            var expected = 25164150;
            var actual = P006.SumSquareDifference(1, 100);
            Assert.AreEqual(expected, actual);

        }

    }
}
