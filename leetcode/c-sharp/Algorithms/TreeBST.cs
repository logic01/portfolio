using Algorithms.Util;

namespace Algorithms
{
    public class TreeBST
    {
        public static TreeNode? Do(TreeNode? node, int val)
        {
            if (node == null)
                return null;

            if (node.Value < val)
                return Do(node.Left, val);

            if (node.Value > val)
                return Do(node.Right, val);

            // node.Value == val
            return node;
        }
    }
}
