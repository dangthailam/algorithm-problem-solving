using System;
namespace LeetCode
{
    public class MoveZeroes
    {
        public void Solve(int[] nums)
        {
            int left = 0, right = nums.Length - 1;

            while (right >= 0 && right < nums.Length && nums[right] == 0)
            {
                right--;
            }

            while (left <= right)
            {
                if (nums[left] == 0)
                {
                    int temp = nums[right];
                    nums[right] = nums[left];
                    int i = left;
                    while (i < right - 1)
                    {
                        nums[i] = nums[i + 1];
                        i++;
                    }
                    nums[right - 1] = temp;
                    right--;
                }
                if (nums[left] != 0)
                {
                    left++;
                }
            }
        }
    }
}
