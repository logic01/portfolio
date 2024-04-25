namespace Algorithms.Practice.RoundFive
{
    public static class SlidingWindows
    {
        /// <summary>
        /// Given an array, find the average of each subarray of ‘K’ contiguous elements in it.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Do()
        {
            var res = Slide([1, 2, 3, 4, 5], 2);

        }

        public static double[] Slide(double[] nums, int k)
        {
            List<double> results = [];

            double total = 0;
            int start = 0;
            int end = 0;

            while (end < k)
            {
                total += nums[end++];
            }

            results.Add(total / k);

            while (end < nums.Length)
            {
                total -= nums[start++];
                total += nums[end++];

                results.Add(total / k);
            }

            return [.. results];
        }
    }
}
