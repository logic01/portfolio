using Algorithms.Util;

namespace Algorithms.Practice.RoundFour
{
    public class FastAndSlowPointers
    {
        /// <summary>
        /// Cycle Check
        /// </summary>
        /// <param name="start"></param>
        public static void Do(Node? start)
        {
            if (start == null || start.Next == null)
                return;

            var slow = start;
            var fast = start.Next;

            while(fast != null)
            {
                if (fast == slow)
                {
                    Console.WriteLine("Cycle");
                    return;
                }

                if (fast.Next == null)
                    break;

                fast = fast.Next.Next;

                slow = slow.Next;

            }

            Console.WriteLine("No Cycle");

        }
    }
}
