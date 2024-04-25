using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RoundOne
{
    public class Q_0152_Maximum_Product_Subarray
    {
        public static void Do()
        {
            // broken
            MaxProduct([2, 3, -2, 4]);
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

            for(int i =0; i < nums.Length; i++)
            {
                int cur = nums[0];

                // finds next max value
                // includes min & max to handle negative flips
                // hold this value so we don't interupt the calc for min
                var temp_max = Math.Max(cur, Math.Max(max_so_far * cur, min_so_far * cur));

                // rest current combo
                min_so_far = Math.Min(cur, Math.Min(max_so_far * cur, min_so_far * cur));
            }

            return 1;
        }
    }
}
/*

Given an integer array nums, find a 
subarray that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

  Example 1:

Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
Example 2:

Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
*/