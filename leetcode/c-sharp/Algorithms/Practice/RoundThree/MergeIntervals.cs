namespace Algorithms.Practice.RoundThree
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

        // Assumes [N][2]
        public static int[][] Merge(int[][] intervals)
        {
            int[][] results = new int[intervals.Length][];
            int resultIndex = 0;

            // Sorting all the intervals (x, y) incase they are not in order
            intervals = intervals.Select(interval =>
            {
                Array.Sort(interval);
                return interval;
            }).ToArray();

            // Sort the list of intervals based on the (x) coordinate
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            int[] current = intervals[0];

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

        public static int[,] Merge(int[,] intervals)
        {
            return intervals;
        }
    }
}
