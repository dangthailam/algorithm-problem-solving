using System;
namespace LeetCode
{
    public class PermutationInString
    {
        public bool Solve(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;

            int x = 0, y = s1.Length;

            while (x <= s2.Length - y)
            {
                var subString = s2.Substring(x, y);
                if (IsPermutation(subString, s1))
                    return true;
                x++;
            }

            return false;
            
        }

        public bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int NO_OF_CHARS = 256;


            // Create a count array and initialize all
            // values as 0
            int[] count = new int[NO_OF_CHARS];
            int i;

            // For each character in input strings, 
            // increment count in the corresponding 
            // count array
            for (i = 0; i < str1.Length; i++)
            {
                count[str1[i]]++;
                count[str2[i]]--;
            }

            // See if there is any non-zero value in 
            // count array
            for (i = 0; i < NO_OF_CHARS; i++)
                if (count[i] != 0)
                    return false;
            return true;

        }
    }
}
