using System;
using System.Collections.Generic;
using System.IO;

namespace SOLIDExamples.SRPBad
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        public void AddEntry(string entry)
        {
            entries.Add(entry);
        }

        public override string ToString()
        {
            return string.Join('\n', entries);
        }

        public void SaveToFile(string filename)
        {

        }

        public string Load(string filename)
        {
            return default;
        }
    }

    public class Sample
    {
        public void Main()
        {
            var journal = new Journal();
            journal.AddEntry("First entry");
            journal.AddEntry("Second entry");
            journal.AddEntry("Third entry");
            journal.SaveToFile("journal.txt");
        }
    }
}