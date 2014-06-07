using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P004Tests
    {
        [Test]
        public void IsPalindrome_9009_True()
        {
            var expected = true;
            var actual = P004.IsPalendrome(9009);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsPalindrome_1234_False()
        {
            var expected = false;
            var actual = P004.IsPalendrome(1234);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetMidPoint_14_7()
        {
            var expected = 7;
            var actual = P004.GetMidPoint(14);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetMidPoint_15_8()
        {
            var expected = 8;
            var actual = P004.GetMidPoint(15);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetMaxPalindromeProduct_10To99_9009()
        {
            var expected = 9009;
            int actual = P004.GetMaxPalindromeProduct(10, 99);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetMaxPalindromeProduct_100To999_9009()
        {
            var expected = 906609;
            int actual = P004.GetMaxPalindromeProduct(100, 999);
            Assert.AreEqual(expected, actual);
        }

    }
}
