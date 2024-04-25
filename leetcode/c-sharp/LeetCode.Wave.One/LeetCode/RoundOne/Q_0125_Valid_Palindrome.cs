
namespace LeetCode.RoundOne
{
    public static class Q_0125_Valid_Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int i = 0;
            int j = s.Length-1;

            while(i < j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }

                if (s[i++] != s[j--])
                    return false;
            }

            return true;
            
        }
    }
}


/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing 
all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
*/