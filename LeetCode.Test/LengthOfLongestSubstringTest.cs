using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class LengthOfLongestSubstringTest
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(4, new LengthOfLongestSubstring().Solve("abcbadca"));
        }
    }
}
