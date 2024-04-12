namespace Algorithms.Util
{
    public class NetworkNode
    {
        public int Value { get; set; }
        public List<NetworkNode> Connections { get; set; } = new();

        public NetworkNode(int value)
        {
            Value = value;
        }

        public NetworkNode(int value, List<NetworkNode> connections)
        {
            Value = value;
            Connections = connections;
        }
    }
}
