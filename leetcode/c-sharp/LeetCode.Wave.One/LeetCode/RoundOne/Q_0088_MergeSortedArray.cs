namespace LeetCode.RoundOne
{
    public class Q_0088_MergeSortedArray
    {
        public static void Do()
        {
            Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }

        private static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index = m + n - 1;

            for (int i = n - 1, j = m - 1; i > -1 || j > -1;)
            {
                if (i == -1)
                {
                    nums1[index--] = nums2[j--];
                    continue;
                }
                else if (j == -1)
                {
                    nums1[index--] = nums1[i--];
                    continue;
                }
                           

                if (nums1[i] > nums2[j])
                    nums1[index--] = nums1[i--];
                else
                    nums1[index--] = nums2[j--];
            }
        }
    }
}

/*
You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, 
representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n 
elements are set to 0 and should be ignored. nums2 has a length of n.
*/
