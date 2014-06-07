using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P020Tests
    {
        [Test]
        public void FactorialDigitSum_10_27()
        {
            var expected = 27;
            var actual = P020.FactorialDigitSum(10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FactorialDigitSum_100_Ansert()
        {
            var expected = 648;
            var actual = P020.FactorialDigitSum(100);
            Assert.AreEqual(expected, actual);
        }
    }
}
