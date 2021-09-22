using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestPalindromSubstring
    {
        public string Solve(string s)
        {
            //if (s.Length == 1) return s;
            //var addedBogusS = string.Join('|', s.Split(""));
            //var arr = new int[addedBogusS.Length];

            //var centerPointer = 0;
            //int center = 0, maxRadius = 0;

            //while(centerPointer < s.Length)
            //{
            //    var radius = 0;

            //    while(centerPointer - (radius + 1) >= 0 
            //        && centerPointer + radius + 1 < addedBogusS.Length 
            //        && addedBogusS.Substring(radius - 1, centerPointer) == addedBogusS.Substring(centerPointer, radius + 1))
            //    {
            //        radius++;
            //    }

            //    if(radius > maxRadius)
            //    {
            //        maxRadius = radius;
            //        center = centerPointer;
            //    }

            //    centerPointer++;

            //}

            //double realCenter = Math.Floor(center / 2);
            //var realRadius = (maxRadius - 1) / 2;
            //return s.Substring();
            return null;

        }

        public bool IsPalindrom(string s)
        {
            if (s.Length == 1)
            {
                return true;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public void Test()
        {
            Console.WriteLine(Solve("bb"));

            Console.ReadLine();
        }
    }
}
