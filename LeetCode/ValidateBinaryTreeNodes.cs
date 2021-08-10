using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class ValidateBinaryTreeNodes
    {
        public bool Solve(int n, int[] leftChild, int[] rightChild)
        {
            var set = new HashSet<int>();

            for(int i = 0; i < n; i++)
            {
                set.Add(i);
            }

            for(int i = 0; i < leftChild.Length; i++)
            {
                if((leftChild[i] != - 1 && !set.Contains(leftChild[i]))
                || (rightChild[i] != -1 && !set.Contains(rightChild[i])))
                {
                    return false;
                }
                set.Remove(leftChild[i]);
                set.Remove(rightChild[i]);
            }

            if(set.Count != 1)
            {
                return false;
            }

            int root = set.First();
            set = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                set.Add(i);
            }

            var queue = new Queue<int>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                int node = queue.Dequeue();

                set.Remove(node);

                if(leftChild[node] != -1)
                {
                    queue.Enqueue(leftChild[node]);
                }

                if (rightChild[node] != -1)
                {
                    queue.Enqueue(rightChild[node]);
                }
            }

            return !set.Any();
        }
    }
}
