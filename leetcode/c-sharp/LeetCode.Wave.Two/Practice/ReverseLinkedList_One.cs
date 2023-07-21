using LeetCode.Wave.Two.Util;

namespace LeetCode.Wave.Two.Practice
{
    /// <summary>
    /// Given a singly linked list, reverse it in place, that is, without using additional memory
    /// </summary>
    public static class ReverseLinkedList_One
    {
        public static void Do(Node? root)
        {
            Node? current = root;
            Node? last = null;

            while (current != null)
            {
                var next = current.next;

                current.next = last;
                last = current;
                current = next;
            }
        }
    }
}
