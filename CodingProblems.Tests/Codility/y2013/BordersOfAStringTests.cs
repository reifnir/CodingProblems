//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CodingProblems.Tests.Codility.y2013
//{
//    [TestFixture]
//    public class BordersOfAStringTests
//    {
//        [Test]
//        public void Left_aaabbbzzz_5_aaabb()
//        {
//            var expected = "aaabb";
//            var actual = Solution.Left("aaabbbzzz", 5);
//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void Right_aaabbbzzz_5_bbzzz()
//        {
//            var expected = "bbzzz";
//            var actual = Solution.Right("aaabbbzzz", 5);
//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void InstanceOfBorderOverlapsWithPrefix_NoOverlap_False()
//        {
//            var expected = false;
//            var actual = Solution.InstanceOfBorderOverlapsWithPrefix("abba", "abbaabbaabba");
//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void InstanceOfBorderOverlapsWithPrefix_Overlap_True()
//        {
//            var expected = true;
//            var actual = Solution.InstanceOfBorderOverlapsWithPrefix("abba", "abbabbaabba");
//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void InstanceOfBorderOverlapsWithSuffix_NoOverlap_False()
//        {
//            var expected = false;
//            var actual = Solution.InstanceOfBorderOverlapsWithSuffix("abba", "abbaabbaabba");
//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void InstanceOfBorderOverlapsWithSuffix_Overlap_True()
//        {
//            var expected = true;
//            var actual = Solution.InstanceOfBorderOverlapsWithSuffix("abba", "abbaabbabba");
//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void RemoveLeadingAndTrailingCharacters_Sample()
//        {
//            var expected = "456";
//            var actual = Solution.RemoveLeadingAndTrailingCharacters("123456789", 3);
//            Assert.AreEqual(expected, actual);
//        }
//    }
//}
