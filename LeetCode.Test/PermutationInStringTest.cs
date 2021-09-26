using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class PermutationInStringTest
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(new PermutationInString().Solve("abc", "dcbad"));
        }
    }
}
