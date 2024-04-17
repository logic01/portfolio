using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Util;

namespace Algorithms.Practice.RoundThree
{
    public static class TreeDFS
    {
        public static void Do()
        {
            var root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Left.Left = new TreeNode(3);
            root.Left.Left.Left = new TreeNode(4);
            root.Left.Left.Right = new TreeNode(5);
            root.Left.Right = new TreeNode(6);

            root.Right = new TreeNode(7);
            root.Right.Left = new TreeNode(8);
            root.Right.Left.Left = new TreeNode(9);
            root.Right.Right = new TreeNode(10);

            Do(root, 10);
        }

        public static TreeNode? Do(TreeNode? root, int val)
        {
            var stack = new Stack<TreeNode>();

            if (root == null)
                return root;

            stack.Push(root);

            while(stack.Count != 0)
            {
                var cur = stack.Pop();

                Console.WriteLine(cur.Value);

                if (cur.Value == val)
                    return cur;

                if (cur.Left != null)
                    stack.Push(cur.Left);

                if (cur.Right != null)
                    stack.Push(cur.Right);
            }

            return root;
        }
    }
}
