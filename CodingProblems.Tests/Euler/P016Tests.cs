using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Numerics;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P016Tests
    {        
        [Test]
        public void SumOfNumberPowerDigits_2_Pow_15_26()
        {
            var expected = 26;
            var actual = P016.SumOfNumberPowerDigits(2, 15);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfNumberPowerDigits_2_Pow_1000_Answer()
        {
            var expected = 1366;
            var actual = P016.SumOfNumberPowerDigits(2, 1000);
            Assert.AreEqual(expected, actual);
        }
    }
}
