using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class SplitPaperPieces_One
    {
        public static void Do()
        {
            int[] o1 = new int[] { 2, 3, 7, 5, 6, 1, 8, 4, 12, 10, 11, 9 };
            int[] d1 = new int[] { 1, 2, 3, 4, 7, 5, 6, 8, 11, 9, 12, 10 };

            Console.WriteLine(Do(o1, d1));

            int[] o2 = new int[] { 1, 4, 3, 2, 5 };
            int[] d2 = new int[] { 1, 4, 3, 5, 2 };


            Console.WriteLine(Do(o2, d2));

            int[] o3 = new int[] { 1, 4, 3, 2 };
            int[] d3 = new int[] { 4, 3, 1, 2 };


            Console.WriteLine(Do(o3, d3));

            int[] o4 = new int[] { 1, 3, 4, 2 };
            int[] d4 = new int[] { 4, 2, 1, 3 };


            Console.WriteLine(Do(o4, d4));
        }

        private static int Do(int[] original, int[] desired)
        {
            int strips = original.Length;

            for (int i = 0; i < original.Length - 1; i++)
            {
                for (int j = 0; j < desired.Length - 1; j++)
                {
                    if ((original[i] == desired[j]) && (original[i + 1] == desired[j + 1]))
                    {
                        strips--;
                    }
                }
            }
            return strips;
        }
    }
}
