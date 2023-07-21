
namespace LeetCode
{
    public class Q_0163_Missing_Ranges
    {
        readonly List<string> ranges = new();
        int? start;

        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {

            int index = 0;

            for (int i = lower; i <= upper; i++)
            {
                if (index > nums.Length - 1 || i != nums[index])
                {
                    if (start == null)
                        start = i;
                    continue;
                }

                if (i == nums[index])
                {
                    if (start != null)
                    {
                        if (i == start + 1)
                            ranges.Add($"{start}");
                        else
                            ranges.Add($"{start}->{i - 1}");
                        start = null;
                    }

                    index++;
                    continue;
                }
            }

            if (start != null)
            {
                if (start == upper)
                    ranges.Add($"{start}");
                else
                    ranges.Add($"{start}->{upper}");
            }

            return ranges;
        }
    }
}
