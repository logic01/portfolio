namespace LeetCode.RoundOne
{
    public static class Q_0053_Maximum_Subarray
    {
        public static void Do()
        {
            int index = 0;
            var res = Divide([1, 2, -1, 3, 5, -5, 3, 5, 6], ref index);
            Console.WriteLine(res);

            index = 0;
            var res2 = Divide([-1, 2, -1, 3, 5], ref index);
            Console.WriteLine(res);
        }

        public static int Divide2(int[] nums, int start, int end)
        {
            var pivot = start + (end - start) / 2;

            int left_max = int.MinValue;
            int left_cur = 0;
            for (int i = pivot - 1; i >= start; i--)
            {
                left_cur += nums[i];
                left_max = Math.Max(left_max, left_cur);
            }

            int right_max = int.MinValue;
            int right_cur = 0;
            for (int i = pivot + 1; i <= end; i++)
            {
                right_max += nums[i];
                right_max = Math.Max(right_max, right_cur);
            }

            int mid = 10;
            int l_total = Divide2(nums, start, mid);

            var r_total = Divide2(nums, mid + 1, end);

            return Math.Max(r_total, l_total + r_total);
        }

        private static int Sum2(int[] nums, ref int index)
        {
            if (index >= nums.Length)
                return 0;

            bool isNeg = nums[index] < 0;

            int total = 0;
            while (index < nums.Length && ((isNeg && nums[index] <= 0) || (!isNeg && nums[index] >= 0)))
                total += nums[index++];

            return total;
        }

        public static int Divide(int[] nums, ref int index)
        {
            if (index >= nums.Length)
                return 0;

            int l_total = Sum(nums, ref index);

            var m_total = Sum(nums, ref index);

            var r_total = Divide(nums, ref index);

            return Math.Max(Math.Max(l_total, l_total + m_total), l_total + m_total + r_total);
        }

        private static int Sum(int[] nums, ref int index)
        {
            if (index >= nums.Length)
                return 0;

            bool isNeg = nums[index] < 0;

            int total = 0;
            while (index < nums.Length && ((isNeg && nums[index] <= 0) || (!isNeg && nums[index] >= 0)))
                total += nums[index++];

            return total;
        }
    }
}

/*
Given an integer array nums, find the subarray with the largest sum, and return its sum.
*/