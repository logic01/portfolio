using Algorithms.Extensions;
using Algorithms.Util;

namespace Algorithms
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Practice.RoundThree.SlidingWindow.Do();
            Practice.RoundFour.SlidingWindows.Do();

            var root = new Node(1);
            root.Next = new Node(2);
            root.Next.Next = new Node(3);
            root.Next.Next.Next = new Node(4);
            root.Next.Next.Next.Next = new Node(5);
            root.Next.Next.Next.Next.Next = new Node(6);

            // no cycle
            Algorithms.Practice.RoundFour.FastAndSlowPointers.Do(root);

            // create a cycle;
            root.Next.Next.Next.Next = root;

            // cycle
            Algorithms.Practice.RoundFour.FastAndSlowPointers.Do(root);

            Parallelism p = new Parallelism();
            await p.WhenAny();
            Console.ReadLine();

            Practice.RoundThree.SlidingWindow.Do();
            Practice.RoundThree.TreeBFS.Do();
            Practice.RoundThree.TreeDFS.Do();
            Practice.RoundTwo.MergeIntervals.Do();
            Practice.RoundThree.MergeIntervals.Do();


            Practice.RoundOne.MultiMap<int, int> map = [];

            foreach (var key in map.Keys)
            {
                var val = map[key];
            }

            foreach (var pair in map)
            {
                Console.WriteLine(pair);
            }

            SyntaxSugar.Do();


            var dfs = new TreeNode(1);
            dfs.Left = new TreeNode(2);
            dfs.Left.Left = new TreeNode(3);
            dfs.Left.Left.Left = new TreeNode(4);
            dfs.Left.Left.Right = new TreeNode(5);
            dfs.Left.Right = new TreeNode(6);

            dfs.Right = new TreeNode(7);
            dfs.Right.Left = new TreeNode(8);
            dfs.Right.Left.Left = new TreeNode(9);
            dfs.Right.Right = new TreeNode(10);

            TreeDFS.Do(dfs, 10);

            var mm1 = new Practice.MultiMap<string, int>
            {
                { "one", new List<int> { 1, 1, 1 } },
                { "two", new List<int> { 2, 2, 2 } }
            };

            var mm2 = new Practice.MultiMap<string, int>
            {
                { "one", new List<int> { 1, 1, 1 } },
                { "three", new List<int> { 3, 3, 3 } }
            };

            var res = mm1.Union(mm2);



            int[] ar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //TwoPointers.Do(ar, ar[6] + ar[12]);

            MergeIntervals.Do();
            Practice.RoundTwo.MergeIntervals.Do();

            //SlidingWindows.Do(new double[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 2);
            //SlidingWindows.Do(new double[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5);




            root = new Node(1);
            root.Next = new Node(2);
            root.Next.Next = new Node(3);
            root.Next.Next.Next = new Node(4);

            // no cycle
            FastAndSlowPointers.Do(root);

            // create a cycle;
            root.Next.Next.Next.Next = root;

            // cycle
            FastAndSlowPointers.Do(root);

            var root_two = new Node(1);
            root_two.Next = new Node(2);
            root_two.Next.Next = new Node(3);
            root_two.Next.Next.Next = new Node(4);

            // list is reversed
            root_two = ReverseLinkedList.Do(root_two);

            // add cycle
            root_two.Next.Next.Next.Next = root_two;

            Practice.RoundTwo.ReverseLinkedList.Do(root_two);



        }
    }
}