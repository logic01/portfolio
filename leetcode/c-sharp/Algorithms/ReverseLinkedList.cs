using Algorithms.Util;

namespace Algorithms
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

            if (root.Next == null)
                return root;

            Node? cur = root;
            Node? prev = null;

            // end of the list
            while (cur != null)
            {
                var temp = cur.Next;

                cur.Next = prev;
                prev = cur;
                cur = temp;
            }

            // this will be the last good node before we hit null end
            return prev;
        }
    }
}
