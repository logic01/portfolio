using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_0088_Merge_Sorted_Array
    {
        public static void Do()
        {
            Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }

        private static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var p1 = m - 1;
            var p2 = n - 1;
            var p = m + n - 1;

            while (p >= 0)
            {
                if (p2 < 0)
                    break;

                if (p1 >= 0 && nums1[p1] > nums2[p2])
                    nums1[p] = nums1[p1--];
                else
                    nums1[p] = nums2[p2--];
                p--;
            }

        }
    }
}
