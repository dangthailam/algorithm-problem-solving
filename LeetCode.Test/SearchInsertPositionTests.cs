using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class SearchInsertPositionTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Assert.AreEqual(1, new SearchInsertPosition().Solve(new int[] { 1, 3, 5, 6 }, 2));
            new SquaresSortedArray().Solve(new int[] { -4, -1, 0, 3, 10 });
        }
    }
}