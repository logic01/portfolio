using Algorithms.Util;

namespace Algorithms.Practice.RoundFour
{
    public class ReverseLinkedList
    {
        public static Node? Do(Node? root)
        {
            if (root == null)
                return root;

            Node? cur = root;
            Node? prev = null;

            while(cur != null)
            {
                var tmp = cur.Next;

                cur.Next = prev;
                prev = cur;
                cur = tmp;
            }

            return prev;
        }
    }
}
