using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class Q_0543
	{
		int max = 0;

		public int DiameterOfBinaryTree(TreeNode root)
		{
			LongestPath(root);

			return max;
		}

		public int LongestPath(TreeNode root)
		{
			if (root == null)
				return 0;

			var left = BinaryTreeDigger(root.left);
			var right = BinaryTreeDigger(root.right);

			max = Math.Max(max, left + right);

			return Math.Max(left, right) + 1;
		}
	}
}
}
