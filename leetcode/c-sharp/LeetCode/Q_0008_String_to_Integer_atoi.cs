using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_0008_String_to_Integer_atoi
    {
        public static void Do()
        {
            MyAtoi_Array("-2147483647");
            var res = MyAtoi("42");
        }
        public static int MyAtoi_Array(string s)
        {
            int negative = 1;
            int i = 0;

            while (i < s.Length && s[i] == ' ')
                i++;

            if (i == s.Length)
                return 0;

            if (s[i] == '+' || s[i] == '-')
            {
                if (s[i] == '-')
                    negative = -1;

                i++;
            }

            int result = 0;

            while (i < s.Length && Char.IsDigit(s[i]))
            {
                int val = s[i] - '0';

                if (negative == 1)
                {
                    if (result > Int32.MaxValue / 10)
                        return Int32.MaxValue;

                    if (result == Int32.MaxValue / 10 && val > 7)
                        return Int32.MaxValue;
                }
                else
                {
                    if (result * negative < Int32.MinValue / 10)
                        return Int32.MinValue;

                    if (result * negative == Int32.MinValue / 10 && val > 8)
                        return Int32.MinValue;
                }

                result = (result * 10) + val;
                i++;
            }

            return result * negative;
        }
        public static int MyAtoi(string s)
        {

            if (string.IsNullOrEmpty(s))
                return 0;

            var queue = new Queue<char>(s.ToCharArray());

            while (queue.Count > 0 && queue.Peek() == ' ')
            {
                _ = queue.Dequeue();
            }

            if (queue.Count == 0)
                return 0;

            var digits = String.Empty;

            if (queue.Peek() == '+' || queue.Peek() == '-')
                digits = queue.Dequeue().ToString();

            while (queue.Count > 0 && Char.IsDigit(queue.Peek()))
            {
                digits += queue.Dequeue().ToString();
            }

            if (String.IsNullOrEmpty(digits) || digits == "+" || digits == "-")
                return 0;

            var dub = double.Parse(digits);

            if (dub >= Int32.MaxValue)
                return Int32.MaxValue;

            if (dub <= Int32.MinValue)
                return Int32.MinValue;

            return Int32.Parse(digits);
        }
    }
}
