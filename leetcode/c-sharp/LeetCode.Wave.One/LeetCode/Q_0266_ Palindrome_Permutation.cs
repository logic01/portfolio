
namespace LeetCode
{
    public static class Q_266__Palindrome_Permutation
    {
        public static bool CanPermutePalindrome(string s)
        {
            var hash = new Dictionary<char, int>();
            var evenCount = 0;

            for (int i = 0; i < s.Length; i++)
            {

                if (hash.ContainsKey(s[i]))
                {
                    var val = hash[s[i]] + 1;

                    if (val % 2 != 0)
                        evenCount++;
                    else
                        evenCount--;

                    hash[s[i]] = val;
                }
                else
                {
                    hash.Add(s[i], 1);
                    evenCount++;
                }
            }

            return evenCount <= 1;
        }
    }
}
