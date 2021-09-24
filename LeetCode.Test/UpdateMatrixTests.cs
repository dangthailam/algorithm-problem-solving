using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class UpdateMatrixTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var mat = new int[3][] {
                new int[] {0, 0, 1, 1 },
                new int[] {0, 1, 0, 1 },
                new int[] {1, 1, 1, 0 }
            };

            var result = new UpdateMatrix().Solve(mat);
        }
    }
}