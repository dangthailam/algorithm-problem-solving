using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class ThreeSumClosest
    {
        public int Solve(int[] nums, int target)
        {
            Array.Sort(nums);
            int start, left, right;
            start = 0;
            int difference = int.MaxValue;
            while (start < nums.Length - 2)
            {
                left = start + 1;
                right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[start] + nums[left] + nums[right];
                    
                    if(Math.Abs(sum - target) < Math.Abs(difference))
                    {
                        difference = sum - target;
                    }
                    if (sum - target < 0)
                    {
                        left++;
                    }
                    else if (sum - target > 0)
                    {
                        right--;
                    }
                    else
                    {
                        return sum;
                    }
                    continue;
                }
                start++;
            }
            return target + difference;
        }
    }
}
