namespace ConvertQueueIntoStack
{
    public static class QueueExtensions
    {
        public static Stack<int> ToStack(this Queue<int> queue)
        {
            // queue FIFO - 
            // A
            // BA
            // CBA
            // PRINT: ABC

            // stack LIFO - 1, 2, 3  -> 1, 2, 3
            // A
            // BA
            // CBA
            // PRINT: CBA

            // cheat way - Show your work!
            // Stack<int> stack = new(queue);
            // Stack<int> stack2 = new(stack);

            Stack<int> stack = new();
            Stack<int> stack2 = new();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                stack2.Push(stack.Pop());
            }

            return stack2;
        }
    }
}
