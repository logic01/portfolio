using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_First_Bad_Version
    {
        public static int FirstBadVersion(int n)
        {
            return Divide(1, n);
        }

        private static int Divide(int start, int end)
        {

            if (start == end)
            {
                return IsBadVersion(start) ? start : -1;
            }

            var mid = start + (end - start) / 2;

            var bad = IsBadVersion(mid);

            if (bad)
            {
                if (mid - 1 < start)
                    return mid;

                var left = Divide(start, mid - 1);

                if (left == -1)
                    return mid;
                else
                    return left;
            }
            else
            {
                if (mid + 1 > end)
                    return -1;

                var right = Divide(mid + 1, end);

                if (right == -1)
                    return mid;
                else
                    return right;
            }

            return -1;
        }

        private static bool IsBadVersion(int v)
        {
            return v >= 4;
        }
    }
}
