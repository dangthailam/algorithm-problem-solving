using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SquaresSortedArray
    {
        public int[] Solve(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int i = right;
            int[] result = new int[nums.Length];
            int ni;
            while (left <= right)
            {
                ni = (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                    ? left++
                    : right--;
                result[i--] = nums[ni] * nums[ni];
            }
            return result;
        }
    }
}
