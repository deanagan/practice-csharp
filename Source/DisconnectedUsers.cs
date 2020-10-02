using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace lib
{
    public class DisconnectedUsers
    {
        private readonly List<(string, string)> _edges;
        private readonly Dictionary<string, int> _lookUp;

        class Node
        {
            public List<Node> Connections { get; set; } = new List<Node>();
            public string Name { get; private set; }
            public int Count { get; private set; }

            public Node(string name, int count)
            {
                Name = name;
                Count = count;
            }
        }


        public DisconnectedUsers(List<(string, string)> edges, Dictionary<string, int> lookUp)
        {
            _edges = edges;
            _lookUp = lookUp;
        }
        public int Total(string source, List<string> crushes)
        {
            // Create a node lookup
            var nodeLookUp = _lookUp.ToDictionary(e => e.Key, e => new Node(e.Key, e.Value));

            // if source is in the crushes array, then return sum of all nodes
            if (crushes.Contains(source))
            {
                return nodeLookUp.Sum(e => e.Value.Count);
            }

            // Add child to each node
            _edges.ForEach(p => nodeLookUp[p.Item1].Connections.Add(nodeLookUp[p.Item2]));

            var connected = new Stack<Node>();
            var visited = new List<string>();

            connected.Push(nodeLookUp[source]);

            while (connected.Count > 0) {
                var node = connected.Pop();
                visited.Add(node.Name);

                node.Connections
                    .Where(conn => !crushes.Contains(conn.Name))
                    .ToList()
                    .ForEach(n => connected.Push(n));
            }

            return nodeLookUp.Sum(kn => visited.Contains(kn.Value.Name) ? 0 : kn.Value.Count);
        }
    }
}
