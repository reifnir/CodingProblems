using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P010Tests
    {
        [Test]
        public void SumOfPrimesLessThanN_10_17()
        {
            var expected = 17;
            var actual = P010.SumOfPrimesLessThanN(10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfPrimesLessThanN_TwoMillion_17()
        {
            var expected = 142913828922;
            var actual = P010.SumOfPrimesLessThanN(2000000);
            Assert.AreEqual(expected, actual);
        }
    }
}
