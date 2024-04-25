using Algorithms.Util;

namespace Algorithms.Practice.RoundFive
{
    public static class FastAndSlowPointers
    {
        /// <summary>
        /// Cycle Check
        /// </summary>
        /// <param name="start"></param>
        public static void Do(Node? start)
        {

            if (start is null || start.Next is null)
            {
                Console.WriteLine("No Cycle");
                return;
            }

            var slow = start;
            var fast = start.Next;

            while (fast != null)
            {
                if (fast == slow)
                {
                    Console.WriteLine("Cycle");
                    return;
                }

                slow = slow?.Next;
                fast = fast?.Next?.Next;
            }

            Console.WriteLine("No Cycle");
        }
    }
}
