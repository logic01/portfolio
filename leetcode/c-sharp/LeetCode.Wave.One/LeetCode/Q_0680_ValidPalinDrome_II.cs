using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_0680_ValidPalinDrome_II
    {
        public static bool ValidPalindrome(string s)
        {
            return IsPalindrome(s);
        }

        private static bool IsPalindrome(string s, int depth = 0)
        {

            // Quick Exits!
            if (String.IsNullOrEmpty(s))
                return true;

            if (s.Length == 1)
                return true;

            if (s.Length == 2 && s[0] == s[1])
                return true;

            if (s.Length == 3 && s[0] == s[2])
                return true;

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                // exit because we already removed a single letter
                if (s[i] != s[j] && depth != 0)
                    return false;

                // lets try each of the substrings
                if (s[i] != s[j] && depth == 0)
                {
                    var sub1 = s[i..j];
                    var sub2 = s.Substring(i + 1, j -1);

                    Console.WriteLine($"i:{i}, j:{j}, s:{sub1} s:{sub2}");

                    return IsPalindrome(sub1, 1) || IsPalindrome(sub2, 1);
                }

                i++;
                j--;
            }

            return true;
        }

    }
}
