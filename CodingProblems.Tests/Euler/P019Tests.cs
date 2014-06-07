using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P019Tests
    {
        [Test]
        public void CountOfSundaysInClosedInterval_Answer()
        {
            var expected = 171;
            var actual = P019.CountOfSundaysOnMonthStartInClosedInterval(new DateTime(1901, 1, 1), new DateTime(2000, 12, 31));
            Assert.AreEqual(expected, actual);
        }
    }
}
