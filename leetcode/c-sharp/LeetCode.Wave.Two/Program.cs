using LeetCode.Wave.Two.Practice;
using LeetCode.Wave.Two.Util;

namespace LeetCode.Wave.Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            TwoPointers.Do(ar, ar[6] + ar[12]);

            SlidingWindows.Do(new double[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 2);
            SlidingWindows.Do(new double[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5);

            MergeIntervals.Do();

            var root = new Node(1);
            root.next = new Node(2);
            root.next.next = new Node(3);
            root.next.next.next = new Node(4);

            // no cycle
            FastAndSlowPointers.Do(root);

            // create a cycle;
            root.next.next.next.next = root;

            // cycle
            FastAndSlowPointers.Do(root);

            var root_two = new Node(1);
            root_two.next = new Node(2);
            root_two.next.next = new Node(3);
            root_two.next.next.next = new Node(4);

            // list is reversed
            root_two = ReverseLinkedList.Do(root_two);

            // add cycle
            root_two.next.next.next.next = root_two;

            ReverseLinkedList_One.Do(root_two);



        }
    }
}