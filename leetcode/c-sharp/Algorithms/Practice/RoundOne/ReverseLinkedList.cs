using Algorithms.Util;

namespace Algorithms.Practice.RoundOne
{
    public static class ReverseLinkedList
    {
        public static Node Do(Node? root)
        {
            Node? prev = null;
            Node? cur = root;

            while (cur != null)
            {
                var tmp = cur.next;

                cur.next = prev;
                prev = cur;
                cur = tmp;
            }

            return prev;
        }
    }
}
