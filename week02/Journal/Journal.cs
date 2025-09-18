using System;
using System.IO;
using System.Collections.Generic;

namespace JournalProgram
{
    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries yet...");
            }
            else
            {
                foreach (Entry e in _entries)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry e in _entries)
                {
                    writer.WriteLine(e.ToFileString());
                }
            }
            Console.WriteLine("Journal saved to " + filename);
        }

        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry e = Entry.FromFileString(line);
                if (e != null)
                {
                    _entries.Add(e);
                }
            }
            Console.WriteLine("Journal loaded from " + filename);
        }
    }
}

