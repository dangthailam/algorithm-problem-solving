using System.Collections.Generic;

namespace LeetCode
{
    public class ShortestBridge
    {
        private int[][] ds = new int[4][]{
            new int[] { 0, 1},
            new int[] { 1, 0 },
            new int[] { 0, -1},
            new int[] { -1, 0 },
        };
        private Queue<(int x, int y)> firstIsland = new Queue<(int x, int y)>();
        private int n;
        private int m;

        public int Solve(int[][] grid)
        {
            n = grid.Length;
            m = grid[0].Length;
            bool foundFirstIsland = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        DFS(grid, i, j);
                        foundFirstIsland = true;
                        break;
                    }
                }

                if (foundFirstIsland)
                    break;
            }

            if (!foundFirstIsland)
                return 0;

            int counter = 0;

            while(firstIsland.Count > 0)
            {
                int size = firstIsland.Count;
                while(size > 0)
                {
                    var p = firstIsland.Dequeue();
                    foreach (var dir in ds)
                    {
                        var x = p.x + dir[0];
                        var y = p.y + dir[1];

                        if (IsSafe(x, y))
                        {
                            if (grid[x][y] == 1)
                                return counter;

                            if(grid[x][y] == 0)
                            {
                                grid[x][y] = 2;
                                firstIsland.Enqueue((x, y));
                            }
                        }
                    }
                    size--;
                }
                counter++;
            }

            return 0;

        }

        private bool IsSafe(int x, int y)
        {
            return x >= 0 && x < n && y >= 0 && y < m;
        }

        private void DFS(int[][] grid, int x, int y)
        {
            firstIsland.Enqueue((x, y));
            grid[x][y] = 2;

            foreach (var dir in ds)
            {
                int newX = x + dir[0];
                int newY = y + dir[1];

                if (IsSafe(newX, newY) && grid[newX][newY] == 1)
                    DFS(grid, newX, newY);
            }
        }

        public void Test()
        {
            var result = Solve(new int[5][]
            {
                new int[] {1,1,0,0,0},
                new int[] {1,0,0,0,0},
                new int[] {1,0,0,0,0},
                new int[] {0,0,0,1,1},
                new int[] {0,0,0,1,1},
            });

        }
    }
}
