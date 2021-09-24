using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class UpdateMatrix
    {
        private int n;
        private int m;
        public int[][] Solve(int[][] mat)
        {
            n = mat.Length;
            m = mat[0].Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        mat[i][j] = DistanceToNearestZero(mat, i, j);
                    }
                }
            }

            return mat;
        }

        public int DistanceToNearestZero(int[][] mat, int x, int y)
        {
            var directions = new int[4][] {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 0, -1 },
                new int[] { -1, 0 },
            };
            int counter = 0;
            bool[,] visit = new bool[n, m];

            var queue = new Queue<int[]>();
            queue.Enqueue(new int[] { x, y });

            while (queue.Count > 0)
            {
                var internalQueue = new Queue<int[]>();

                while (queue.Count > 0)
                {
                    internalQueue.Enqueue(queue.Dequeue());
                }

                while (internalQueue.Count > 0)
                {
                    var cell = internalQueue.Dequeue();
                    visit[cell[0], cell[1]] = true;

                    if (mat[cell[0]][cell[1]] == 0)
                        return counter;

                    foreach (var d in directions)
                    {
                        var newCell = new int[] { cell[0] + d[0], cell[1] + d[1] };

                        if (IsSafe(mat, newCell[0], newCell[1]) && !visit[newCell[0], newCell[1]])
                        {
                            queue.Enqueue(newCell);
                        }
                    }
                }

                counter++;
            }

            return counter;
        }

        public bool IsSafe(int[][] mat, int x, int y)
        {
            return x >= 0 && x < n && y >= 0 && y < m;
        }
    }
}
