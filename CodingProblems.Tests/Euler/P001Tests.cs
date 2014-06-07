using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    //Multiples of 3 and 5
    [TestFixture]
    internal class P001Tests
    {
        [Test]
        public void SumOfMultiplesOfThreeAndFive_1To9_Equals23()
        {
            var expected = 23;

            var actual = new P001().SumOfMultiplesOfThreeAndFive(1, 9);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SumOfMultiplesOfThreeAndFive_1To999_Equals23()
        {
            var expected = 233168;

            var actual = new P001().SumOfMultiplesOfThreeAndFive(1, 999);

            Assert.AreEqual(expected, actual);
        }
    }
}
