using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class FloodFillTest
    {
        [TestMethod]
        public void Test()
        {
            var image = new int[3][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
            };

            new FloodFill().Solve(image, 1, 1, 2);


        }
    }
}
