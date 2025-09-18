using System;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGen = new PromptGenerator();

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine();
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display all entries");
                Console.WriteLine("3. Load from file");
                Console.WriteLine("4. Save to file");
                Console.WriteLine("5. Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry(DateTime.Now, prompt, response);
                    journal.AddEntry(entry);
                }
                else if (choice == "2")
                {
                    journal.DisplayEntries();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter filename: ");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                }
                else if (choice == "4")
                {
                    Console.Write("Enter filename: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                }
                else if (choice == "5")
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
