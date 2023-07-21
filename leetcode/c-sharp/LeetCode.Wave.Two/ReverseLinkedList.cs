using LeetCode.Wave.Two.Util;

namespace LeetCode.Wave.Two
{
    /// <summary>
    /// Given a singly linked list, reverse it in place, that is, without using additional memory
    /// </summary>
    public static class ReverseLinkedList
    {
        public static Node? Do(Node? root)
        {
            if (root == null)
                return root;

            if (root.next == null)
                return root;

            Node? cur = root;
            Node? prev = null;

            // end if we hit a cycle
            while (cur != null)
            {
                var next = cur.next;

                cur.next = prev;
                prev = cur;
                cur = next;
            }

            // this will be the last good node before we hit null end
            return prev;
        }
    }
}
