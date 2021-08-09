using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            var stack = new Stack<(int currentSum, TreeNode node)>();

            stack.Push((0, root));

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                var node = current.Item2;

                var sum = current.Item1;

                if (node.left == null && node.right == null && targetSum == sum + node.val)
                {
                    return true;
                }

                if (node.left != null)
                    stack.Push((sum + node.val, node.left));

                if (node.right != null)
                    stack.Push((sum + node.val, node.right));
            }

            return false;
        }
    }
}
