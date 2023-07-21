using LeetCode.Wave.Two.Util;

namespace LeetCode.Wave.Two
{
    public static class FastAndSlowPointers
    {
        /// <summary>
        /// Cycle Check
        /// </summary>
        /// <param name="start"></param>
        public static void Do(Node? start)
        {
            if (start == null)
            {
                Console.WriteLine("No-Cycle");
                return;
            }

            Node fast = start;
            Node slow = start;

            while (true)
            {
                if (fast.next == null || fast.next.next == null)
                {
                    Console.WriteLine("No-Cycle");
                    return;
                }

                fast = fast.next.next;
                slow = slow.next; // Will not be null because of fast null checks

                if (fast == slow)
                {
                    Console.WriteLine("Cycle");
                    return;
                }
            }
        }
    }
}
