using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class BinaryTreeDiameter
    {
        int diam = 0;

        public int Solve(TreeNode root)
        {
            DFS(root);
            return diam;
        } 

        private int DFS(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = DFS(root.left);
            int right = DFS(root.right);

            diam = Math.Max(diam, left + right);

            return Math.Max(left, right) + 1;
        }


        // not work
        public int SolveByMyOwn(TreeNode root)
        {
            if (root == null) return 0;

            (int counter, TreeNode newRoot) = CleanTree(root);

            if (newRoot.left == null && newRoot.right == null)
                return counter - 1;


            int max = MaxDepth(newRoot);
            int min = MinDepth(newRoot);

            var leafToLeaf = max + min - 2;

            if (leafToLeaf < counter)
            {
                return counter + max - 2;
            }
            return leafToLeaf;
        }

        public (int, TreeNode) CleanTree(TreeNode root)
        {
            var node = root;
            int counter = 0;
            while (node != null)
            {
                counter++;
                if ((node.left != null && node.right != null)
                || (node.left == null && node.right == null))
                    return (counter, node);

                node = node.left ?? node.right;
            }

            return (counter, node);
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int depthLeft = MaxDepth(root.left);
            int depthRight = MaxDepth(root.right);

            return Math.Max(depthLeft, depthRight) + 1;
        }

        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            var q = new Queue<List<TreeNode>>();

            q.Enqueue(new List<TreeNode> { root });

            int depth = 0;

            while (q.Count != 0)
            {
                depth++;
                var sameLevelNodes = q.Dequeue();

                List<TreeNode> childrenNodes = new List<TreeNode>();
                foreach (var node in sameLevelNodes)
                {
                    if (node.left == null && node.right == null)
                    {
                        return depth;
                    }
                    if (node.left != null)
                    {
                        childrenNodes.Add(node.left);
                    }
                    if (node.right != null)
                    {
                        childrenNodes.Add(node.right);
                    }
                }
                q.Enqueue(childrenNodes);
            }

            return depth;
        }
    }
}
