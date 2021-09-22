using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MaxAreaOfIsland
    {
        private int[][] directions = new int[4][]
        {
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { -1, 0 },
        };

        public int Solve(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            List<int> areas = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int counter = DFS(grid, i, j);
                        areas.Add(counter);
                    }
                }
            }

            return areas.Any() ? areas.Max() : 0;
        }

        public int DFS(int[][] grid, int x, int y)
        {
            int counter = 0;
            if (!IsSafe(grid, x, y))
                return counter;

            grid[x][y] = 2;
            counter++;

            foreach (var d in directions)
            {
                counter += DFS(grid, x + d[0], y + d[1]);
            }

            return counter;
        }

        public bool IsSafe(int[][] grid, int x, int y)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            return x >= 0 && x < n && y >= 0 && y < m && grid[x][y] == 1;
        }
    }
}
