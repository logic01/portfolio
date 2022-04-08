using LeetCode.Helpers;

namespace LeetCode
{
    public static class Q_0938_Range_Sum_Of_BST
    {
        public static int Do(TreeNode root, int low, int high)
        {
            if (root == null)
                return 0;

            var sum = 0;

            if (root.val >= low && root.val <= high)
                sum += root.val;

            if (root.val >= low)
                sum += Do(root.left, low, high);

            if (root.val <= high)
                sum += Do(root.right, low, high);

            return sum;
        }
    }
}
