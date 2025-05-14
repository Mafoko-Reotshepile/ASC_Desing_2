using System.Collections.Generic;

namespace ASC_Desing_2
{
    public class MemoryManager
    {
        private List<string> memory = new List<string>();

        public void Store(string input)
        {
            memory.Add(input);
        }

        public string Recall()
        {
            return memory.Count > 0 ? string.Join(", ", memory) : "I don't remember anything yet.";
        }
    }
}
