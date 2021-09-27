using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// Enqueue all 0 and then perform BFS for each cell of 0
    /// Maintain seen array for every cell
    /// If cell X has not been seen, increment the value of parent cell by 1 then assign it into cell X
    /// The effect should be like Flood Fill problem
    /// </summary>
    public class UpdateMatrix
    {
        private int n;
        private int m;
        public int[][] Solve(int[][] mat)
        {
            n = mat.Length;
            m = mat[0].Length;

            var directions = new int[4][] {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 0, -1 },
                new int[] { -1, 0 },
            };

            bool[][] seen = new bool[n][];
            for(int i = 0; i < n; i++)
            {
                seen[i] = new bool[m];
            }

            var queue = new Queue<(int x, int y)>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        queue.Enqueue((i, j));
                        seen[i][j] = true;
                    }
                }
            }

            while(queue.Count > 0)
            {
                int total = queue.Count;

                while(total > 0)
                {
                    var cell = queue.Dequeue();

                    foreach (var d in directions)
                    {
                        int newX =  cell.x + d[0], newY = cell.y + d[1];

                        if (IsSafe(mat, newX, newY) && !seen[newX][newY])
                        {
                            queue.Enqueue((newX, newY));
                            mat[newX][newY] = mat[cell.x][cell.y] + 1;
                            seen[newX][newY] = true;
                        }
                    }

                    total--;
                }
            }

            return mat;
        }

        public bool IsSafe(int[][] mat, int x, int y)
        {
            return x >= 0 && x < n && y >= 0 && y < m;
        }
    }
}
