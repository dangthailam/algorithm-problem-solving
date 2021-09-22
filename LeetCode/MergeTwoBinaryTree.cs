using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MergeTwoBinaryTree
    {
        public TreeNode Solve(TreeNode root1, TreeNode root2)
        {
            var queue1 = new Queue<TreeNode>();
            var queue2 = new Queue<TreeNode>();

            queue1.Enqueue(root1);
            queue2.Enqueue(root2);

            while(queue1.Count > 0 && queue2.Count > 0)
            {
                var node1 = queue1.Dequeue();
                var node2 = queue2.Dequeue();

                node1.val += node2.val;

                if(node1.left != null && node2.left == null)
                {
                    node2.left = new TreeNode();
                }
                if(node1.left == null && node2.left != null)
                {
                    node1.left = new TreeNode();
                }

                if (node1.right != null && node2.right == null)
                {
                    node2.right = new TreeNode();
                }
                if (node1.right == null && node2.right != null)
                {
                    node1.right = new TreeNode();
                }
                if (node1.left != null)
                    queue1.Enqueue(node1.left);
                if (node1.right != null)
                    queue1.Enqueue(node1.right);
                if (node2.left != null)
                    queue2.Enqueue(node2.left);
                if (node2.right != null)
                    queue2.Enqueue(node2.right);
            }

            return root1;
        }
    }
}
