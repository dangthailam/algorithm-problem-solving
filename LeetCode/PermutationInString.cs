//using System;
//namespace LeetCode
//{
//    public class PermutationInString
//    {
//        public bool Solve(string s1, string s2)
//        {
//            if (s1.Length > s2.Length) return false;

//            int x = 0, y = s1.Length;

//            while(x <= s2.Length - y)
//            {
//                var subString = s2.Substring(x, y);
//                if (IsPermutation(subString, s2))
//                    return true;
//                x++;
//            }

//            return false;
            
//        }

//        public bool IsPermutation(string s1, string s2)
//        {
//            if (s1.Length != s2.Length)
//                return false;

            

//        }
//    }
//}
