using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class BinaryTreeDiameterTest
    {
        [TestMethod]
        public void Test()
        {
            var tree = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)));

            var result = new BinaryTreeDiameter().Solve(tree);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test1()
        {
            var tree = new TreeNode(3, new TreeNode(1, null, new TreeNode(2)));

            var result = new BinaryTreeDiameter().Solve(tree);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test2()
        {
            var tree = new TreeNode(2, new TreeNode(3, new TreeNode(1, new TreeNode(4))));

            var result = new BinaryTreeDiameter().Solve(tree);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test3()
        {
            var tree = new TreeNode(2,
                new TreeNode(5,
                    new TreeNode(3,
                        new TreeNode(1),
                        new TreeNode(4)
                    )
                )
            );

            var result = new BinaryTreeDiameter().Solve(tree);

            Assert.AreEqual(3, result);
        }
    }
}
