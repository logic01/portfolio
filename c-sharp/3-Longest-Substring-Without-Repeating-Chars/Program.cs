using System;
using System.Collections.Generic;

// https://leetcode.com/problems/longest-substring-without-repeating-characters/
// Given a string s, find the length of the longest substring without repeating characters.

namespace _3_Longest_Substring_Without_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3
            LengthOfLongestSubstring("abcabcbb");
        }

        public static void LengthOfLongestSubstring(string s)
        {
            var substrings = new List<String>();
            string value = string.Empty;
            var chars = s.ToCharArray();

            foreach (var c in chars)
            {
                substrings.AddRange(s.Split(c));
            }

            
        }
    }
}
