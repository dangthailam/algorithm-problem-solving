using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LengthOfLongestSubstring
    {

        public int Solve(string s)
        {
            var set = new HashSet<char>();
            var chars = s.ToCharArray();
            int maxLength = 0;
            var longestSubstr = new List<char>();


            for (int i = 0; i < chars.Length; i++)
            {
                var c = chars[i];
                if (!set.Contains(c))
                {
                    set.Add(c);
                }
                else
                {
                    maxLength = Math.Max(maxLength, longestSubstr.Count);
                    longestSubstr = longestSubstr.Skip(longestSubstr.IndexOf(c) + 1).ToList();
                }

                longestSubstr.Add(c);
                set = longestSubstr.ToHashSet();
            }

            return Math.Max(maxLength, longestSubstr.Count);
        }
    }
}
