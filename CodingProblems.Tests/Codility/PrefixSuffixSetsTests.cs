using CodingProblems.Implementation.Codility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Tests.Codility
{
    [TestFixture]
    public class PrefixSuffixSetsTests
    {
        private int[] BaseSet = new int[] { 3, 5, 7, 3, 3, 5 };

        [Test]
        public void GetPrefixSuffixSets_ExampleGiven()
        {
            var set = BaseSet;
            var expected = 14;

            var actual = new PrefixSuffixSets().GetPrefixSuffixSetCount(set);

            Assert.AreEqual(expected, actual);
        }
        /*
        [Test]
        public void CreatePrefixIndexRanges_ExpectedResults()
        {
            var set = BaseSet;
            var expected = new List<PrefixSuffixSets.NumberIndexRange>()
            {
                new PrefixSuffixSets.NumberIndexRange() { Number = 3, IndexStart= 0, IndexEnd = 0 },
                new PrefixSuffixSets.NumberIndexRange() { Number = 5, IndexStart= 1, IndexEnd = 1 },
                new PrefixSuffixSets.NumberIndexRange() { Number = 7, IndexStart= 2, IndexEnd = 5 }
            };

            var actual = PrefixSuffixSets.CreatePrefixIndexRanges(set);

            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.IsTrue(AreEqual(expected[i], actual[i]));
            }
            
        }
        [Test]
        public void CreateSuffixIndexRanges_ExpectedResults()
        {
            var set = BaseSet;
            var expected = new List<PrefixSuffixSets.NumberIndexRange>()
            {
                new PrefixSuffixSets.NumberIndexRange() { Number = 5, IndexStart= 5, IndexEnd = 5 },
                new PrefixSuffixSets.NumberIndexRange() { Number = 3, IndexStart= 3, IndexEnd = 4 },
                new PrefixSuffixSets.NumberIndexRange() { Number = 7, IndexStart= 0, IndexEnd = 2 }
            };

            var actual = PrefixSuffixSets.CreateSuffixIndexRanges(set);

            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.IsTrue(AreEqual(expected[i], actual[i]));
            }
        }
        
        private bool AreEqual(PrefixSuffixSets.NumberIndexRange a, PrefixSuffixSets.NumberIndexRange b)
        {
            return a.Number == b.Number && a.IndexStart == b.IndexStart && a.IndexEnd == b.IndexEnd;
        }
        */
    }
}
