using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RoundOne
{
    public static class Q_0076_Min_window_Substring
    {
        public static void Do()
        {
            Slide("fabcdefg", "ff");
        }

        public static void Slide(string s, string t)
        {
            int start = int.MaxValue;
            int end = int.MinValue;
            Dictionary<char, int> tracker = [];

            for (int i = 0; i < t.Length; i++)
            {
                int skip = 0;

                if (!tracker.TryAdd(t[i], 1))
                {
                    skip = tracker[t[i]]++;
                }

                for (int j = 0; j < s.Length; j++)
                {
                    if (t[i] == s[j])
                    {
                        if(skip != 0)
                        {
                            skip--;
                            continue;
                        }
                        if (j < start)
                            start = j;

                        if (j > end)
                            end = j;

                        break;
                    }
                }
            }

            Console.WriteLine(s.Substring(start, end-start+1));
        }
    }
}

/*
Given two strings s and t of lengths m and n respectively, return the minimum window 
substring
 of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

 
Example 1:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
Example 2:

Input: s = "a", t = "a"
Output: "a"
Explanation: The entire string s is the minimum window.
Example 3:

Input: s = "a", t = "aa"
Output: ""
Explanation: Both 'a's from t must be included in the window.
Since the largest window of s only has one 'a', return empty string.
 

Constraints:

m == s.length
n == t.length
1 <= m, n <= 105
s and t consist of uppercase and lowercase English letters.
 

Follow up: Could you find an algorithm that runs in O(m + n) time?
*/