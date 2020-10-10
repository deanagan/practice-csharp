using System.Linq;
using System.Collections.Generic;

namespace lib
{
    public class StressSubjectAnalyzer
    {
        public bool IsStressful(string input)
        {
            if (input.EndsWith("!!!") || (input.ToUpper() == input))
            {
                return true;
            }
            input = input.ToLower();
            var cleanSubject = string.Join("", input.Where((ch,index) => (index == 0) || (ch != input[index - 1])));
            var redWords = new List<string> { "urgent", "help", "asap"};
            return redWords.Any((redWord) => cleanSubject.Contains(redWord));
        }
    }
}
