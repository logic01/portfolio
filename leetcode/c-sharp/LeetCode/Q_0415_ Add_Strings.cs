using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_415__Add_Strings
    {
        public static string AddStrings(string num1, string num2)
        {
            var result = String.Empty;
            var carry = 0;

            int i = num1.Length - 1;
            int j = num2.Length - 1;

            while (i >= 0 || j >= 0)
            {
                // converts ascii to decimal
                var c1 = i < 0 ? 0 : num1[i] - '0';
                var c2 = j < 0 ? 0 : num2[j] - '0';

                // get ascii dec value
                var digit = c1 + c2 + carry;

                carry = 0;

                if (digit >= 10)
                {
                    carry = 1;
                    digit -= 10;
                }

                result = $"{digit}{result}";

                i--;
                j--;

            }

            if (carry == 1)
                return $"1{result}";

            return result;
        }
    }
}
