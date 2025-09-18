using System;

namespace JournalProgram
{
    public class Entry
    {
        public DateTime Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(DateTime date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()} \nPrompt: {Prompt}\nResponse: {Response}\n";
        }

        public string ToFileString()
        {
            return $"{Date.ToString("o")}|{Prompt}|{Response}";
        }

        public static Entry FromFileString(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 3)
            {
                return null;
            }
            DateTime date = DateTime.Parse(parts[0]);
            return new Entry(date, parts[1], parts[2]);
        }
    }
}
