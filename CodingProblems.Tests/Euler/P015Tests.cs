using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;
using System.Numerics;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P015Tests
    {
        [Test]
        public void RoutesThroughGrid_2x2_2()
        {
            var expected = new BigInteger(2);
            var actual = P015.RoutesThroughGrid(1, 1);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void RoutesThroughGrid_3x3_6()
        {
            var expected = new BigInteger(6);
            var actual = P015.RoutesThroughGrid(2, 2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void RoutesThroughGrid_21x21_Answer()
        {
            var expected = new BigInteger(137846528820);
            var actual = P015.RoutesThroughGrid(20,20);
            Assert.AreEqual(expected, actual);
        }
    }
}
