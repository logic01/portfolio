
using LeetCode.Helpers;

namespace LeetCode
{
    public static class Q_0270_Closest_Binary_Search_Tree_Value
    {
        public static int ClosestValue(Node root, double target)
        {

            var current = root;
            var min_distance = double.MaxValue;
            var min_value = 0;

            while (current != null)
            {

                var new_distance = Math.Abs(target - current.val);

                if (new_distance < min_distance)
                {
                    min_distance = new_distance;
                    min_value = current.val;
                }

                // found you!
                if (target == current.val)
                    return current.val;

                // walk left
                if (target < current.val)
                {
                    current = current.left;
                    continue;
                }

                // walk right
                if (target > current.val)
                {
                    current = current.right;
                    continue;
                }
            }

            return min_value;
        }
    }
}
