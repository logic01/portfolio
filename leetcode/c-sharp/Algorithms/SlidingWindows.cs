namespace Algorithms
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

            var avg_index = 0;
            var open = 0;
            var close = 1;
            var sum = nums[0];
            var avgs = new double[nums.Length - k + 1]; // init array length based on # of windows.

            while (close <= nums.Length - 1)
            {
                sum += nums[close++];

                if (close >= k)
                {
                    avgs[avg_index++] = sum / k;
                    sum -= nums[open++];
                }
            }

            return avgs;
        }
    }
}
