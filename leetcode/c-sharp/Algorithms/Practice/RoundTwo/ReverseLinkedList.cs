using Algorithms.Util;

namespace Algorithms.Practice.RoundTwo
{
    /// <summary>
    /// Given a singly linked list, reverse it in place, that is, without using additional memory
    /// </summary>
    public static class ReverseLinkedList
    {
        public static void Do(Node? root)
        {
            Node? current = root;
            Node? last = null;

            while (current != null)
            {
                var next = current.Next;

                current.Next = last;
                last = current;
                current = next;
            }
        }
    }
}
