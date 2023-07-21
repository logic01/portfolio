using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_0014_Longest_Common_Prefix
    {
        public static void Do()
        {
            var v1 = Divide(new string[] { "flower", "flow", "flight" }, 0, 2);
            var v2 = Divide(new string[] { "dog", "racecar", "car" }, 0, 2);
        }

        public static string ColumnBasedPrefix(string[] strs)
        {

            if (strs.Length == 0)
                return string.Empty;

            if (strs.Length == 1)
                return strs[0];

            var prefix = string.Empty;
            var i = 0;

            while (true)
            {

                var c = ' ';

                foreach (var str in strs)
                {

                    // no more chars to consume so end prefix loop.
                    if (i == str.Length)
                        return prefix;

                    // capture first char of the first string
                    if (c == ' ')
                        c = str[i];

                    if (str[i] != c)
                        return prefix;
                }

                prefix += c.ToString();

                i++;
            }
        }
       
        public static string Divide(string[] strs, int start, int end)
        {
            if (start == end)
                return strs[start];

            if (end - start == 1)
                return PrefixOf(strs[start], strs[end]);

            var mid = start + (end - start) / 2;

            return PrefixOf(Divide(strs, start, mid), Divide(strs, mid + 1, end));
        }

        private static string PrefixOf(string str1, string str2)
        {
            StringBuilder prefix = new();
            int i = 0;

            while (i < str1.Length && i < str2.Length && str1[i] == str2[i])
            {
                prefix.Append(str1[i]);
                i++;
            }

            return prefix.ToString();
        }
    }
}
