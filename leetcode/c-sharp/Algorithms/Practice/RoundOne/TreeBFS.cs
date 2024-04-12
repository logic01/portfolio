using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Util;

namespace Algorithms.Practice.RoundOne
{
    public class TreeBFS
    {
        public static TreeNode? Do(TreeNode? root, int val)
        {
            if (root == null)
                return root;

            var que = new Queue<TreeNode>();

            que.Enqueue(root);

            while (que.Count > 0)
            {
                var current = que.Dequeue();

                if (current.Value == val)
                    return current;

                if (current.Left != null)
                    que.Enqueue(current.Left);

                if (current.Right != null)
                    que.Enqueue(current.Right);
            }

            Console.WriteLine("Not Found");
            return null;
        }
    }
}
