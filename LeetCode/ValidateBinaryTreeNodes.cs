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

        public void Test()
        {

            var result = Solve(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, -1, -1, -1 });
            var result1 = Solve(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, 3, -1, -1 });
            var result2 = Solve(2, new int[] { 1, 0 }, new int[] { -1, -1 });
            var result3 = Solve(6, new int[] { 1, -1, -1, 4, -1, -1 }, new int[] { 2, -1, -1, 5, -1, -1 });
            var result4 = Solve(4, new int[] { 1, 0, 3, -1 }, new int[] { -1, -1, -1, -1 });

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}
