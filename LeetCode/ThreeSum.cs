using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ThreeSum
    {
        public IList<IList<int>> Solve(int[] A)
        {
            int size = A.Length;
            int sum = 0;
            var result = new List<IList<int>>();
            // Fix the first element as A[i]
            for (int i = 0; i < size - 2; i++)
            {
                // Find pair in subarray A[i+1..n-1]
                // with sum equal to sum - A[i]
                HashSet<int> s = new HashSet<int>();
                int curr_sum = sum - A[i];
                for (int j = i + 1; j < size; j++)
                {
                    if (s.Contains(curr_sum - A[j]))
                    {
                        Console.Write("Triplet is {0}, {1}, {2}", A[i],
                                      A[j], curr_sum - A[j]);
                        result.Add(new List<int>
                        {
                            A[i],
                            A[j],
                            curr_sum - A[j]
                        });
                    }
                    s.Add(A[j]);
                }
            }

            // If we reach here, then no triplet was found
            return result;
        }

        public void Test()
        {
            Solve(new int[] { -1, 0, 1, 2, -1, -4 });

            Console.ReadLine();
        }
    }
}
