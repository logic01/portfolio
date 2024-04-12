using System.Security.Cryptography;
using Algorithms.Util;

namespace Algorithms
{
    public static class TreeDFS
    {
        public static TreeNode? Do(TreeNode? root, int val)
        {
            var stack = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                var cur = stack.Pop();

                Console.WriteLine($"{cur.Value}");
                if (cur.Value == val)
                    return cur;

                if (cur.Right != null)
                    stack.Push(cur.Right);

                if (cur.Left != null)
                    stack.Push(cur.Left);


            }

            return null;
        }
    }
}
