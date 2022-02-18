// See https://aka.ms/new-console-template for more information
using ConvertQueueIntoStack;

Console.WriteLine("Hello, World!");

Queue<int> q1 = new(new[] { 1, 2, 3, 4, 5 });
PrintQueue(q1);

var stack = q1.ToStack();
PrintStack(stack);

Console.ReadLine();

void PrintQueue(Queue<int> q)
{
    Queue<int> pq = new(q);
    string s = string.Empty;

    while (pq.Count > 0)
    {
        s += $"{pq.Dequeue()}";
    }
    Console.WriteLine("Queue: " + s);
}

void PrintStack(Stack<int> s)
{
    string str = string.Empty;

    while (s.Count > 0)
    {
        str += $"{s.Pop()}";
    }
    Console.WriteLine("STACK: " + str);
}