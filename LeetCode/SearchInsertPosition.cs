using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SearchInsertPosition
    {
        public int Solve(int[] nums, int target)
        {
            int left = 0, right = nums.Length;

            if (target > nums[right - 1])
                return right;

            if (target < nums[left])
                return left;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                    return mid;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}
