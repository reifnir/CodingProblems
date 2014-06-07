using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P023Tests
    {
        [Test]
        public void IsAbundantNumber_11_False()
        {
            var expected = false;
            var actual = P023.IsAbundantNumber(11);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsAbundantNumber_12_True()
        {
            var expected = true;
            var actual = P023.IsAbundantNumber(12);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfAllNonAbundantSums_Answer()
        {
            var expected = 391258627;
            var actual = P023.SumOfAllNonAbundantSums();
            Assert.AreEqual(expected, actual);
        }

    }
}
