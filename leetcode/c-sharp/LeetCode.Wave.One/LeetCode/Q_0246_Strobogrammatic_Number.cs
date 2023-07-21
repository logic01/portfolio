namespace LeetCode
{
    public static class Q_0246_Strobogrammatic_Number
    {
        public static bool IsStrobogrammatic(string num)
        {
            var inverse = new Dictionary<char, char>
            {
                { '6', '9' },
                { '9', '6' },
                { '8', '8' },
                { '1', '1' },
                { '0', '0' }
            };

            var s = num.ToString();

            int i = 0;
            int j = s.Length - 1;

            while (i <= j)
            {

                // only 0, 1, 6, 8, 9 can be flipped
                if (!inverse.ContainsKey(s[i]) || !inverse.ContainsKey(s[j]))
                    return false;

                // does our left match our right's inverse
                if (s[i] != inverse[s[j]])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}
