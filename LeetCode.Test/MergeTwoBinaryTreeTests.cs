using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class MergeTwoBinaryTreeTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            var root1 = new TreeNode(1, new TreeNode(3, new TreeNode(5)), new TreeNode(2));
            var root2 = new TreeNode(2, new TreeNode(1, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(7)));
            var result = new MergeTwoBinaryTree().Solve(root1, root2);
        }
    }
}