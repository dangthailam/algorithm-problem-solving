using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class PlusOne
    {
        public int[] Solve(int[] digits)
        {

            int length = digits.Length;
            int lastDigit = digits[length - 1];

            if (lastDigit == 9)
            {
                int counter = 0;
                while (lastDigit == 9)
                {
                    counter++;
                    if (counter == length)
                        break;
                    lastDigit = digits[length - 1 - counter];
                }

                int newLength = counter == length ? length + 1 : length;

                int[] newArr = new int[newLength];

                if (counter < length)
                {

                    for (int i = 0; i < newArr.Length - counter - 1; i++)
                    {
                        newArr[i] = digits[i];
                    }
                    newArr[newArr.Length - counter - 1] = digits[newArr.Length - counter - 1] + 1;
                }
                else
                {
                    newArr[newArr.Length - counter - 1] = 1;
                }

                for (int i = counter; i > 0; i--)
                {
                    newArr[newArr.Length - i] = 0;
                }

                return newArr;
            }
            else
            {
                digits[length - 1]++;
                return digits;
            }
        }

        [TestMethod]
        public void Test()
        {
            Solve(new int[] { 9, 9 }); // 1, 0, 0
            Solve(new int[] { 1, 9, 9 }); // 2, 0, 0
        }
    }
}
