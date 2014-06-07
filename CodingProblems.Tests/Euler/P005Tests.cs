using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P005Tests
    {


        [Test]
        public void GetPrimeFactorsAndCounts_6_2And3()
        {
            var expected = new Dictionary<int, int>()
            {
                { 2, 1 },
                { 3, 1 }
            };
            var actual = Common.GetPrimeFactorsAndCounts(6);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetPrimeFactorsAndCounts_12_2_2_And3_1()
        {
            var expected = new Dictionary<int, int>()
            {
                { 2, 2 },
                { 3, 1 }
            };
            var actual = Common.GetPrimeFactorsAndCounts(12);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSmallestMultiple_From1To10_2520()
        {
            var expected = 2520;
            var actual = P005.GetSmallestMultiple(1, 10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetSmallestMultiple_From1To20_2520()
        {
            var expected = 232792560;
            var actual = P005.GetSmallestMultiple(1, 20);
            Assert.AreEqual(expected, actual);
        }

    }
}
