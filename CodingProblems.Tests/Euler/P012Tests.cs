using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P012Tests
    {
        [Test]
        public void GetFirstTriangleNumberWithOverNDivisors_Solution_GetResults()
        {
            var expected = 76576500;
            var actual = new P012().GetFirstTriangleNumberWithAtLeastNDivisors(500);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetTriangleNumbers_4_GivenResults()
        {
            var expected = new List<int> { 1, 3, 6, 10 };
            var actual = P012.GetTriangleNumbers(4);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFirstTriangleNumberWithOverNDivisors_5_28()
        {
            var expected = 28;
            var actual = new P012().GetFirstTriangleNumberWithAtLeastNDivisors(5);
            Assert.AreEqual(expected, actual);
        }
    }
}
