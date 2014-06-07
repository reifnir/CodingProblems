using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P021Tests
    {
        [Test]
        public void SumOfDivisors_220_284()
        {
            var expected = 284;
            var actual = P021.SumOfDivisors(220);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfDivisors_284_220()
        {
            var expected = 220;
            var actual = P021.SumOfDivisors(284);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsAmicableNumber_220_True()
        {
            var expected = true;
            var actual = P021.IsAmicableNumber(220);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsAmicableNumber_221_False()
        {
            var expected = false;
            var actual = P021.IsAmicableNumber(221);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfAllAmicableNumbersUnderN_10000_Answer()
        {
            var expected = 31626;
            var actual = P021.SumOfAllAmicableNumbersUnderN(10000);
            Assert.AreEqual(expected, actual);
        }
    }
}
