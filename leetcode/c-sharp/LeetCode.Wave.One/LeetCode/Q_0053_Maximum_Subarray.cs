namespace LeetCode
{
    public static class Q_0053_Maximum_Subarray
    {
        public static int Do(int[] nums)
        {
            return MaxSubArray_Divide(nums);

            // return MaxSubArray_OnePass(nums);

            // return MaxSubArray_Brute(nums);
        }
        public static int MaxSubArray_Divide(int[] nums)
        {
            int a, b = 1;

            if (nums.Length == 1)
                return nums[0];

            return Divide(nums, 0, nums.Length - 1);
        }

        // time & space
        // t-O(n \ log n)) s-O(1)
        public static int Divide(int[] nums, int start, int end)
        {
            if (start > end)
                return Int32.MinValue;

            var pivot = start + (end - start) / 2;

            // find max left sum
            int left_cur = 0;
            int left_max = Int32.MinValue;
            for (int i = pivot - 1; i >= start; i--)
            {
                left_cur += nums[i];
                left_max = Math.Max(left_max, left_cur);
            }

            // find max right sum
            int right_cur = 0;
            int right_max = Int32.MinValue;
            for (int i = pivot + 1; i <= end; i++)
            {
                right_cur += nums[i];
                right_max = Math.Max(right_max, right_cur);
            }

            var mid = nums[pivot] + left_max + right_max;
            var left = Divide(nums, start, pivot - 1);
            var right = Divide(nums, pivot + 1, end);

            return Math.Max(mid, Math.Max(left, right));
        }

        // t-O(N) s-O(1)
        public static int MaxSubArray_OnePass(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            var max = Int32.MinValue;

            var curSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                curSum += nums[i];

                max = Math.Max(max, curSum);

                curSum = curSum > 0 ? curSum : 0;
            }

            return max;
        }

        // t-O(n^2) s-O(1)
        public static int MaxSubArray_Brute(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            int maxSum = nums[0];

            for (var i = 0; i < nums.Length; i++)
            {
                var sum = nums[i];

                maxSum = Math.Max(sum, maxSum);

                for (var j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    maxSum = Math.Max(sum, maxSum);

                }
            }

            return maxSum;
        }
    }
}
