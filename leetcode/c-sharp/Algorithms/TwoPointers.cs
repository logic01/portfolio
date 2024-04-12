
namespace Algorithms
{
    public static class TwoPointers
    {
        /// <summary>
        /// Given an array of sorted numbers and a target sum, find a pair in the array whose sum is equal to the given target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="total"></param>
        public static void Do(int[] nums, int total)
        {
            int i = 0;
            int j = nums.Length - 1;

            while (i < j)
            {
                int current = nums[i] + nums[j];

                if (current == total)
                {
                    i++;
                    Console.WriteLine($"{nums[i]} + {nums[j]} = {total}");
                }
                else if (current < total)
                    i++;
                else if (current > total)
                    j--;

            }
        }
    }
}
