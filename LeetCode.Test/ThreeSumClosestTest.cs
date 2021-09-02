using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class ThreeSumClosestTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, new ThreeSumClosest().Solve(new int[] { -1, 2, 1, -4 }, 1)); // should equal 2
            Assert.AreEqual(13, new ThreeSumClosest().Solve(new int[] { 1, 2, 5, 10, 11 }, 12)); // should equal 13
            Assert.AreEqual(-2, new ThreeSumClosest().Solve(new int[] { 4, 0, 5, -5, 3, 3, 0, -4, -5 }, -2)); // should equal -2
            Assert.AreEqual(0, new ThreeSumClosest().Solve(new int[] { -55, -24, -18, -11, -7, -3, 4, 5, 6, 9, 11, 23, 33 }, 0)); // should equal 0
        }
    }
}
