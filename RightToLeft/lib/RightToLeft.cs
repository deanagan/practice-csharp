using System;
using System.Linq;

namespace lib
{
    public class RightToLeft
    {
        public string ReplaceRightWithLeft(string[] inputs)
        {
            return string.Join(",", inputs.Select(word => word.Replace("right", "left")));
        }
    }
}
