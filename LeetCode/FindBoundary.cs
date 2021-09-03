using System;
namespace LeetCode
{
    public class FindBoundary
    {
        bool IsBadVersion(int n)
        {
            return n >= 1702766719;

        }
        public int Solve(int n)
        {
            int left = 1, right = n;
            int firstBadVersion = -1;

            while (left <= right)
            {
                int mid = (int)(((long)left + right) / 2);
                bool isBad = IsBadVersion(mid);
                if (isBad)
                {
                    firstBadVersion = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return firstBadVersion;
        }
    }
}
