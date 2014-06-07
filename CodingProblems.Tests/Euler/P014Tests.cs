using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P014Tests
    {
        [Test]
        public void GetNumberOfTermsInCollatzSequence_13_10()
        {
            var collatzSequencer = new P014();
            var expected = 10;
            var actual = collatzSequencer.GetNumberOfTermsInCollatzSequence(13);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetLowestCollatzNumberLessThanN_Solution_Answer()
        {
            var collatzSequencer = new P014();
            var expected = 837799;
            var actual = collatzSequencer.GetLowestCollatzNumberLessThanN(1000000);
            Assert.AreEqual(expected, actual);
        }
    }
}
