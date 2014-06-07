using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P003Tests
    {

        [Test]
        public void GetMaxPrimeFactor_600851475143_ExpectedValues()
        {
            var expected = 6857;

            var actual = P003.GetMaxPrimeFactor(600851475143);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetPrimeFactors_42_ExpectedValues()
        {
            var expected = new List<int>() { 2, 3, 7 };
            var actual = P003.GetPrimeFactors(42);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetMaxPrimeFactor_42_ExpectedValues()
        {
            var expected = 7;
            var actual = P003.GetMaxPrimeFactor(42);
            Assert.AreEqual(expected, actual);
        }
    }
}
