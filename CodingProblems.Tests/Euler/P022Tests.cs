using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingProblems.Implementation.Euler;
using CodingProblems.Tests.Properties;

namespace CodingProblems.Test.Euler
{
    [TestFixture]
    public class P022Tests
    {
        [Test]
        public void GetNameValueForPosition_COLIN_937_79714()
        {
            var expected = 49714;
            var actual = P022.GetNameValueForPosition("COLIN", 937);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetNameValue_COLIN_53()
        {
            var expected = 53;
            var actual = P022.GetNameValue("COLIN");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSumOfNameValuesByPosition_Example_Answer()
        {
            var expected = 871198282;
            var actual = P022.GetSumOfNameValuesByPosition(Resources.names);
            Assert.AreEqual(expected, actual);
        }
    }
}
