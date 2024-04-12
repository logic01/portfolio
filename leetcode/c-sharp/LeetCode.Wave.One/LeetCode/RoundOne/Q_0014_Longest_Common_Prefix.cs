using System.Text;

namespace LeetCode.RoundOne
{
    public class Q_0014_Longest_Common_Prefix
    {
        public static void Do()
        {
            var k1 = DividePrefix(new string[] { "abcococ", "abckcoc", "abcoclc" }, 0, 2);
            var k2 = DividePrefix(new string[] { "flower", "flow", "flight" }, 0, 2);
            var k3 = DividePrefix(new string[] { "dog", "racecar", "car" }, 0, 2);

            var v1 = FindPrefix(new string[] { "abcococ", "abckcoc", "abcoclc" });
            var v2 = FindPrefix(new string[] { "flower", "flow", "flight" });
            var v3 = FindPrefix(new string[] { "dog", "racecar", "car" });
        }

        public static string FindPrefix(string[] words)
        {
            // Shortest word means longest possible prefix
            var short_word = words.OrderBy(s => s.Length).First();
            int index = short_word.Length - 1;

            for (int i = short_word.Length - 1; i >= 0; i--)
            {
                foreach (var word in words)
                {
                    if (word[i] != short_word[i])
                    {
                        index = i;
                        break;
                    }
                }
            }

            return short_word[..index];
        }

        public static string DividePrefix(string[] words, int start, int end)
        {
            if (end - start == 0)
                return words[start];

            if (end - start == 1)
                return GetPrefix(words[start], words[end]);

            var mid = start + (end - start) / 2;
            var fx_start = DividePrefix(words, start, mid);
            var fx_end = DividePrefix(words, mid + 1, end);

            return GetPrefix(fx_start, fx_end);
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
