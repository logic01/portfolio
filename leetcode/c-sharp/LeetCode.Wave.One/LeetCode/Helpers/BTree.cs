namespace LeetCode.Helpers
{
    public class BTree
    {
        Node root { get; set; }

        public BTree(int value)
        {
            this.root = new Node(value);
        }
        public void Add(int value)
        {
            var node = new Node(value);

            var current = this.root;
            while (true)
            {
                if (current == null)
                {
                    current = node;
                }

                if (current.val < value)
                {
                    current = current.left;
                    continue;
                }

                if (current.val > value)
                {
                    current = current.right;
                    continue;
                }

            }
        }
    }
}
