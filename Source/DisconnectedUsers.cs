using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace lib
{
    public class DisconnectedUsers
    {
        private readonly List<(string, string)> _edges;
        private readonly Dictionary<string, int> _lookUp;

        public DisconnectedUsers(List<(string, string)> edges, Dictionary<string, int> lookUp)
        {
            _edges = edges;
            _lookUp = lookUp;
        }
        public int Total(string source, List<string> crushes)
        {

            return 0;
        }
    }
}
