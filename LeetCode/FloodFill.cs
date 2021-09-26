using System;
namespace LeetCode
{
    public class FloodFill
    {
        private int[][] directions = new int[4][] {
            new int[] { 0, 1 },
            new int[] { 0, -1 },
            new int[] { 1, 0 },
            new int[] { -1, 0 },
        };

        private int firstPixel = -1;

        private bool IsSafe(int[][] image, int sr, int sc)
        {
            int n = image.Length;
            int m = image[0].Length;

            return sr >= 0 && sr < n && sc >= 0 && sc < m && image[sr][sc] == firstPixel;
        }

        public int[][] Solve(int[][] image, int sr, int sc, int newColor)
        {
            firstPixel = image[sr][sc];
            if (firstPixel == newColor)
                return image;

            DFS(image, sr, sc, newColor);

            return image;
        }

        public void DFS(int[][] image, int sr, int sc, int newColor)
        {
            if (!IsSafe(image, sr, sc)) return;

            image[sr][sc] = newColor;

            foreach (var direction in directions)
            {
                DFS(image, sr + direction[0], sc + direction[1], newColor);
            }
        }
    }
}
