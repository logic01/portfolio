
using Algorithms.Util;

namespace Algorithms
{
    public static class TreeBFS
    {
        public static TreeNode? Do(TreeNode? root, int val)
        {
            if (root == null)
                return root;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.Value == val)
                {
                    Console.WriteLine("Found");
                    return current;
                }

                if (current.Left != null)
                    queue.Enqueue(current.Left);

                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }

            Console.WriteLine("Not Found");
            return null;
        }
    }
}
