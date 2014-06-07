using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P007Tests
    {
        [Test]
        public void GetNthPrimeNumber_6_13()
        {
            var expected = 13;
            var actual = P007.GetNthPrimeNumber(6);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetNthPrimeNumber_10001_13()
        {
            var expected = 104743;
            var actual = P007.GetNthPrimeNumber(10001);
            Assert.AreEqual(expected, actual);
        }
    }
}
