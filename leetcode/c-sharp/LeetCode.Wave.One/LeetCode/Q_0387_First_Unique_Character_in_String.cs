
namespace LeetCode
{
    public static class Q_0387_First_Unique_Character_in_String
    {
        public static int FirstUniqChar(string s)
        {
            var hash = new Dictionary<char, Tuple<int, int>>();

            for (var i = 0; i < s.Length; i++)
            {

                if (hash.ContainsKey(s[i]))
                    hash[s[i]] = Tuple.Create(hash[s[i]].Item1, hash[s[i]].Item2 + 1);
                else
                    hash.Add(s[i], Tuple.Create(i, 1));
            }

            foreach (var v in hash.Values)
            {
                if (v.Item2 == 1)
                    return v.Item1;
            }

            return -1;
        }
    }
}
