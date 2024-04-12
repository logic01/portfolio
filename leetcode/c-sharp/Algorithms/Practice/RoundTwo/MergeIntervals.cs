namespace Algorithms.Practice.RoundTwo
{
    public class MergeIntervals
    {
        public static void Do()
        {
            int[][] data = new int[5][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, new int[] { 9, 0 } };

            var resD = Merge(data);

            int[][] one = new int[2][]
            {
                new int[] { 1, 3 },
                new int[] { 1, 2 }
            };

            var res = Merge(one);

            int[][] two = new int[2][]
            {
                new int[] { 1, 3 },
                new int[] { 3, 4 }
            };

            var resTwo = Merge(two);

            int[][] three = new int[2][]
            {
                new int[] { 1, 4 },
                new int[] { 3, 4 }
            };

            var resThree = Merge(three);

        }

        public static int[][] Merge(int[][] intervals)
        {
            int[][] results = new int[intervals.Length][];
            int resultIndex = 0;

            intervals = intervals.Select(i =>
            {
                Array.Sort(i);
                return i;
            }).ToArray();

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            int[] current = intervals[0];

            foreach (var interval in intervals)
            {
                if (interval[0] == current[0] || interval[0] <= current[1])
                {
                    current[1] = Math.Max(current[1], interval[1]);
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
