using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    /// <summary>
    /// Two pointer: 1st pointer which loops the original array, 2nd pointer increment and loops through the target array
    /// </summary>
    [TestClass]
    public class RemoveDuplicatedElementInSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;

            if (length == 0)
                return 0;

            int i = 0;
            int j = 1;

            while (j < length)
            {
                if (nums[i] < nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }

                j++;
            }
            return i;

            // First try

            //int pointer = 999;
            //for (int i = nums.Length - 1; i >= 0; i--)
            //{
            //    if (pointer != nums[i])
            //    {
            //        pointer = nums[i];
            //    }
            //    else
            //    {
            //        for(int j = i; j < nums.Length - 1; j++)
            //        {
            //            nums[j] = nums[j + 1];
            //        }
            //        nums[nums.Length - 1] = -101;
            //    }
            //}
            //return nums.Count(n => n > -101);
        }

        [TestMethod]
        public void Test()
        {
            int[] nums = new int[] { 1, 1, 2 };

            int[] expectedNums = new int[] { 1, 2 }; // The expected answer with correct length

            int k = RemoveDuplicates(nums); // Calls your implementation

            Assert.AreEqual(k, expectedNums.Length);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(nums[i], expectedNums[i]);
            }
        }


    }
}
