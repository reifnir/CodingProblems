using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    class P002Tests
    {
        [Test]
        public void SumOfEvenFibonacciNumbersLessOrEqualToN_NEquals10_SumIs10()
        {
            var expected = 10;
            var actual = new P002().SumOfEvenFibonacciNumbersLessThanN(10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfEvenFibonacciNumbersLessOrEqualToN_NEquals4000000_SumIs4613732()
        {
            var expected = 4613732;
            var actual = new P002().SumOfEvenFibonacciNumbersLessThanN(4000000);
            Assert.AreEqual(expected, actual);
        }
    }
}
