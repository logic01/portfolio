using Algorithms.Util;

namespace Algorithms.Practice.RoundTwo
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
                var node = queue.Dequeue();

                if (node.Value == val)
                {
                    Console.WriteLine("Found");
                    return node;
                }

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            Console.WriteLine("Not Found");
            return null;

        }
    }
}