using System;

class Program
{
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Quit");
            Console.Write("Select: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": new BreathingActivity().Run(); break;
                case "2": new ListingActivity().Run(); break;
                case "3": new ReflectingActivity().Run(); break;
                case "4": exit = true; break;
                default:
                    Console.WriteLine("Invalid choice."); 
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress Enter to return to menu...");
                Console.ReadLine();
            }
        }
    }
}
