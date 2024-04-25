using Algorithms.Util;

namespace Algorithms.Practice.RoundFour
{
    public class TreeBFS
    {
        public static TreeNode? Do(TreeNode? root, int val)
        {
            if (root == null)
                return root;

            var q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                var cur = q.Dequeue();

                if (cur.Value == val)
                    return cur;

                if (cur.Left != null)
                    q.Enqueue(cur.Left);

                if (cur.Right != null)
                    q.Enqueue(cur.Right);
            }

            return null;
        }
    }
}
