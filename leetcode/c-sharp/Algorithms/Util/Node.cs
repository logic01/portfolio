
namespace Algorithms.Util
{
    public class Node
    {
        public int val;
        public Node? Next;

        public Node(int val = 0, Node? next = null)
        {
            this.val = val;
            this.Next = next;
        }
    }
}
