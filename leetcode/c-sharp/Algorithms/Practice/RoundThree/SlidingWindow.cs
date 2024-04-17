using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Practice.RoundThree
{
    /// <summary>
    /// Given an array, find the average of each subarray of ‘K’ contiguous elements in it.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public static class SlidingWindow
    {
        public static void Do()
        {
            var res = Slide([1, 2, 3, 4, 5], 2);
        }

        // find maximum 
        public static double[] Slide(double[] nums, int k)
        {
            List<double> data = [];

            int index = 0;
            double total = 0;

            while(index < k)
            {
                total += nums[index++];
            }

            data.Add(total / k);

            while(index < nums.Length)
            {
                total -= nums[index - k];
                total += nums[index++];

                data.Add(total / k);
            }

            return data.ToArray();
        }
    }
}
