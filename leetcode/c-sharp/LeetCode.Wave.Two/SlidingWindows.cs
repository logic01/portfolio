

using System;

namespace LeetCode.Wave.Two
{
    public static class SlidingWindows
    {
        /// <summary>
        /// Given an array, find the average of each subarray of ‘K’ contiguous elements in it.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static double[] Do(double[] nums, int k)
        {
            if (nums.Length < k)
                throw new ArgumentOutOfRangeException(nameof(k));

            if (k == 0)
                return Array.Empty<double>();

            if (k == 1)
                return nums;

            var a = 0;
            var i = 0;
            var j = 1;
            var sum = nums[0];
            var avgs = new double[nums.Length - k + 1]; // init array length based on # of windows.

            while (j <= nums.Length - 1)
            {
                sum += nums[j++];

                if (j >= k)
                {
                    avgs[a++] = sum / k;
                    sum -= nums[i++];
                }
            }

            return avgs;
        }
    }
}
