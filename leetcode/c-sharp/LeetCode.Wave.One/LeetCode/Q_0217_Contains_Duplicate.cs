namespace LeetCode
{
    public static class Q_0217_Contains_Duplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            return nums.Distinct().Count() != nums.Length;
        }
    }
}
