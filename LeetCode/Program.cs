using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryTreeNodes = new ValidateBinaryTreeNodes();

            var result = binaryTreeNodes.Solve(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, -1, -1, -1 });
            var result1 = binaryTreeNodes.Solve(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, 3, -1, -1 });
            var result2 = binaryTreeNodes.Solve(2, new int[] { 1, 0 }, new int[] { -1, -1 });
            var result3 = binaryTreeNodes.Solve(6, new int[] { 1, -1, -1, 4, -1, -1 }, new int[] { 2, -1, -1, 5, -1, -1 });
            var result4 = binaryTreeNodes.Solve(4, new int[] { 1, 0, 3, -1 }, new int[] { -1, -1, -1, -1 });

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}
