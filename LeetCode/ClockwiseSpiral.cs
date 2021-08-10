using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ClockwiseSpiral
    {
        public List<int> Solve(List<List<int>> matrix)
        {
            int n = matrix.Count;
            int m = matrix[0].Count;
            var set = new HashSet<(int x, int y)>();
            var result = new List<int>();

            int i = 0, j = 0;

            var direction = new int[][]
            {
                new int[] { 0, 1 }, // right
                new int[] { 1, 0 }, // down
                new int[] { 0, -1 }, // left
                new int[] { -1, 0 }, // up
            };

            var directionPointer = 0;

            while (!set.Contains((i, j)))
            {
                var currentDirection = direction[directionPointer];
                result.Add(matrix[i][j]);
                set.Add((i, j));

                var newI = i + currentDirection[0];
                var newJ = j + currentDirection[1];

                if (newI < 0 || newI >= n || newJ < 0 || newJ >= m || set.Contains((newI, newJ)))
                {
                    directionPointer++;
                    if (directionPointer >= direction.Length)
                    {
                        directionPointer = 0;
                    }
                    currentDirection = direction[directionPointer];
                    newI = i + currentDirection[0];
                    newJ = j + currentDirection[1];
                }

                i = newI;
                j = newJ;
            }

            return result;
        }

        public void Test()
        {
            var arr = new List<List<int>> {
                new List<int> {1,  2,  3,  4,  5, 9},
                new List<int> {6,  7,  8,  9,  10, 99},
                new List<int> {11, 12, 13, 14, 15, 999},
                new List<int> {16, 17, 18, 19, 20, 99999},
                new List<int> {21, 22, 23, 24, 25, 9999}
            };

            var result = Solve(arr);

            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();
        }
    }
}
