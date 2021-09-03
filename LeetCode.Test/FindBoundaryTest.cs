using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class FindBoundaryTest
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1702766719, new FindBoundary().Solve(2126753390));
        }
    }
}
