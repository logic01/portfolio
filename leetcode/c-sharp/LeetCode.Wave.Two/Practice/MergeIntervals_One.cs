using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Wave.Two.Practice
{
    public static class MergeIntervals_One
    {
        public static int[][] Do(int[][] data)
        {
            var results = data.ToList();

            var start = new int[results.Count];
            var end = new int[results.Count];
            var i = 0;

            foreach (var item in results)
            {
                start[i] = item[0];
                end[i] = item[1];
                i++;
            }

            Array.Sort(start);
            Array.Sort(end);

            var current = new int[] { start[0], end[0] };

            var k = 1;

            results.Clear();

            while (k <= results.Count - 1)
            {
                if (current[0] >= start[k])
                {
                    current[1] = end[k];
                }
                else
                {
                    results.Add(current);
                    current = new int[] { start[k], end[k] };
                }

                k++;
            }

            //Add the last non-overlapping conditon
            results.Add(current);

            return results.ToArray();


        }
    }
}
