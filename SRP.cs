using System;
using System.Collections.Generic;

namespace SOLIDExamples.SRP
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

    }

    public class JournalSource
    {
        private Journal journal;

        public JournalSource(Journal journal)
        {
            this.journal = journal;
        }

        public void SaveToFile(string filename)
        {

        }

        public string Load(string filename)
        {
            return default;
        }
        public string Load(Uri filename)
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

            var storage = new JournalSource(journal);
            storage.SaveToFile("journal.txt");
        }
    }
}