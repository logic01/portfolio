namespace Algorithms.Practice.RoundFour
{
    public static class MergeIntervals
    {
        public static void Do()
        {
            var res = Merge([[1, 2], [3, 4], [5, 6], [7, 8], [9, 0]]);
            res = Merge([[1, 3], [1, 2]]);
            res = Merge([[1, 3], [3, 4]]);
            res = Merge([[1, 4], [3, 4]]);
        }

        public static int[][] Merge(int[][] intervals)
        {
            var results = new int[intervals.Length][];

            intervals = intervals.Select(interval =>
            {
                Array.Sort(interval);
                return interval;
            }).ToArray();

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            int[] current = intervals[0];
            int resultIndex = 0;

            foreach (var interval in intervals)
            {
                if (interval[0] <= current[1])
                {
                    current[1] = Math.Max(interval[1], current[1]);
                    continue;
                }

                results[resultIndex++] = current;
                current = interval;
            }

            results[resultIndex] = current;

            return results.Where(r => r != null).ToArray();
        }
    }
}
