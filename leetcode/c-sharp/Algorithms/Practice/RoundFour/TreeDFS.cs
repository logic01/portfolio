using Algorithms.Util;

namespace Algorithms.Practice.RoundFour
{
    public class TreeDFS
    {
        public static TreeNode? Do(TreeNode? root, int val)
        {
            if (root == null)
                return root;

            Stack<TreeNode> stack = [];

            stack.Push(root);

            while (stack.Count > 0)
            {
                var cur = stack.Pop();

                if (cur.Value == val)
                    return cur;

                if (cur.Left != null)
                    stack.Push(cur.Left);
                if (cur.Right != null)
                    stack.Push(cur.Right);
            }

            return null;
        }
    }
}