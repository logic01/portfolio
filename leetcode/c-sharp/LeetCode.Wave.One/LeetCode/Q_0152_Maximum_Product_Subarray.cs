using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_0152_Maximum_Product_Subarray
    {
        public static void Do()
        {

        }
        public static int MaxProduct(int[] nums)
        {

            if (nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return nums[0];

            if (nums.Length == 2)
                return Math.Max(nums[0] * nums[1], Math.Max(nums[0], nums[1]));

            // Combo Chain
            // Product Disruptions - Zero, Negatives        
            var max_so_far = nums[0];
            var min_so_far = nums[0];
            var result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {

                var curr = nums[i];

                // finds next max value
                // includes min & max to handle negative flips
                // hold this value so we don't interupt the calc for min
                var temp_max = Math.Max(curr, Math.Max(max_so_far * curr, min_so_far * curr));

                // rest current combo
                min_so_far = Math.Min(curr, Math.Min(max_so_far * curr, min_so_far * curr));

                max_so_far = temp_max;

                result = Math.Max(max_so_far, result);

            }

            return result;
        }
    }
}
