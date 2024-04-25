using Algorithms.Util;

namespace Algorithms
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
                if (fast.Next == null || fast.Next.Next == null)
                {
                    Console.WriteLine("No-Cycle");
                    return;
                }

                fast = fast.Next.Next;
                slow = slow.Next; // Will not be null because of fast null checks

                if (fast == slow)
                {
                    Console.WriteLine("Cycle");
                    return;
                }
            }
        }
    }
}
