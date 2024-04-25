using System.Text;

namespace LeetCode.RoundTwo
{
    public class Q_0014_Longest_Common_Prefix
    {
        public static void Do()
        {
            var k1 = DividePrefix(new string[] { "abcococ", "abckcoc", "abcoclc" }, 0, 2);
            var k2 = DividePrefix(new string[] { "flower", "flow", "flight" }, 0, 2);
            var k3 = DividePrefix(new string[] { "dog", "racecar", "car" }, 0, 2);

        }

        public static string DividePrefix(string[] words, int start, int end)
        {
            // Start & End are in the same position
            // so just return that word
            if (end - start == 0)
                return words[start];

            // Bottom of our tree, only two words to inspect
            if (end - start == 1)
                return GetPrefix(words[start], words[end]);

            // Split the array and get prefix of both sides
            int mid = start + (end - start) / 2;

            var leftPrefix = DividePrefix(words, start, mid);
            var rightPrefix = DividePrefix(words, mid+1, end);

            return GetPrefix(leftPrefix, rightPrefix);
        }

        public static string GetPrefix(string start, string end)
        {
            int i = 0, j = 0;
            StringBuilder sb = new();
            while (i < start.Length && j < end.Length && start[i] == end[j])
            {
                sb.Append(start[i]);
                i++;
                j++;
            }

            return sb.ToString();
        }
    }
}


/*
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".
*/