using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class MoveZeroesTest
    {
        [TestMethod]
        public void Test()
        {
            new MoveZeroes().Solve(new int[] { 0, 0, 0, 3, 12, 0, 1 });
        }
    }
}
