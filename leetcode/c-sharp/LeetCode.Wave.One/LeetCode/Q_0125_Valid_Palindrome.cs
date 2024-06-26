﻿
namespace LeetCode
{
    public static class Q_0125_Valid_Palindrome
    {
        public static bool IsPalindrome(string s)
        {

            if (s.Length == 0)
                return false;

            if (s.Length == 1)
                return true;

            var i = 0;
            var j = s.Length - 1;
            s = s.ToUpper();

            while (i < j)
            {
                bool skip = false;
                if (!Char.IsLetter(s[i]) && !Char.IsDigit(s[i]))
                {
                    i++;
                    skip = true;
                }

                if (!Char.IsLetter(s[j]) && !Char.IsDigit(s[j]))
                {
                    j--;
                    skip = true;
                }

                if (skip)
                    continue;

                if (s[i] != s[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}


/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing 
all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
*/