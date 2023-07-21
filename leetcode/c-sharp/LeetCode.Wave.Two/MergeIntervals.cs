namespace LeetCode.Wave.Two
{
    /// <summary>
    /// Given a list of intervals, merge all the overlapping intervals to produce a list 
    /// with only mutually exclusive intervals.
    /// </summary>
    public static class MergeIntervals
    {
        public static void Do()
        {
            int[][] data  = new int[5][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, new int[] { 9, 0 } };

            var result = Merge(data);
        }

        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> results = intervals.ToList();

            // Less than = 1 interval no overlap possible
            if (intervals.Length <= 1) return intervals;

            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];

            //populate start and end intervals
            for (int k = 0; k < intervals.Length; k++)
            {
                start[k] = results[k][0];
                end[k] = results[k][1];
            }

            // Sort intervals
            Array.Sort(start);  //   1, 3, 5, 7, 9
            Array.Sort(end);    //   0, 2, 4, 6, 8

            //Clear list as it will be used to store the merged intervals
            results.Clear();

            // Current interval store
            int[] current = new int[] { start[0], end[0] };
            int i = 1;
            while (i < intervals.Length)
            {
                // means over lap of ith and i+1 interval
                if (current[1] >= start[i])
                {
                    current[1] = end[i];
                }
                else
                {
                    // store non-overlapping interval
                    results.Add(current);
                    //set current to ith element
                    current = new int[] { start[i], end[i] };
                }
                i++;
            }

            //Add the last non-overlapping conditon
            results.Add(current);

            return results.ToArray();
        }
    }
}
