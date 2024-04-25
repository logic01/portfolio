using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Practice.RoundFour
{
    public class SlidingWindows
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

            int start = 0;
            int end = 0;
            double total = 0;

            while (end < k)
                total += nums[end++];

            results.Add(total / k);

            while (end < nums.Length)
            {
                total -= nums[start++];
                total += nums[end++];

                results.Add(total / k);
            }

            return results.ToArray();
        }
    }
}
