using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Practice.RoundFive
{
    public static class MergeIntervals
    {
        public static void Do()
        {

        }

        public static int[][] Merge(int[][] intervals)
        {
            intervals = intervals.Select(interval =>
            {
                Array.Sort(interval);
                return interval;
            }).ToArray();

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> results = [];

            int[] current = intervals[0];

            foreach(var interval in intervals)
            {
                if (interval[0] <= current[1])
                {
                    current[1] = Math.Max(interval[1], current[1]);
                    continue;
                }

                current = interval;
            }

            results.Add(current);

            return results.ToArray();
        }
    }
}
