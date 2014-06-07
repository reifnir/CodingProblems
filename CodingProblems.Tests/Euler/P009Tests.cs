using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P009Tests
    {
        [Test]
        public void IsPythagoreanTriplet_3_4_5()
        {
            var expected = true;
            var actual = P009.IsPythagoreanTriplet(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsPythagoreanTriplet_3_4_6()
        {
            var expected = false;
            var actual = P009.IsPythagoreanTriplet(3, 4, 6);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindPythagoreanTripletTotallingN_1000_Result()
        {
            var expected = new List<int>() { 200, 375, 425 };
            var actual = P009.FindPythagoreanTripletTotallingN(1000);

            var product = 1;
            actual.ForEach(x => product *= x);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FindPythagoreanTripletTotallingN_3_EmptyList()
        {
            var expected = new List<int>();
            var actual = P009.FindPythagoreanTripletTotallingN(3);
            Assert.AreEqual(expected, actual);
        }
    }
}
