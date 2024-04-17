using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Util;

namespace Algorithms.Practice.RoundThree
{
    public static class TreeBFS
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

            Find(root, 5);
        }

        public static TreeNode? Find(TreeNode? root, int val)
        {
            var q = new Queue<TreeNode>();

            if (root == null)
                return root;

            q.Enqueue(root);

            while(q.Count != 0)
            {
                var cur = q.Dequeue();

                Console.WriteLine(cur.Value);

                if (cur.Value == val)
                    return cur;

                if (cur.Right != null)
                    q.Enqueue(cur.Right);

                if (cur.Left != null)
                    q.Enqueue(cur.Left);
            }

            return root;
        }
    }
}
