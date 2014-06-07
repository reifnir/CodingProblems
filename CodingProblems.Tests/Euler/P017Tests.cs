using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P017Tests
    {
        [Test]
        public void OneToNine()
        {
            var expected = 36;
            var actual = P017.OneToNine();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TenToNineteen()
        {
            var expected = 70;
            var actual = P017.TenToNineteen();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TwentyToNinetyNine()
        {
            var expected = 748;
            var actual = P017.TwentyToNinetyNine();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneHundredToNineHundredNinetyNine()
        {
            var expected = 20259;
            var actual = P017.OneHundredToNineHundredNinetyNine();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneThousand()
        {
            var expected = 11;
            var actual = P017.OneThousand();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneToOneThousand()
        {
            var expected = 21124;
            var actual = P017.OneToOneThousand();
            Assert.AreEqual(expected, actual);
        }
    }
}
