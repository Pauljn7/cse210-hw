using System;

namespace EternalQuest
{
    class Program
    {
        // Creative note: I added an Achievement system that gives small rewards
        // when certain things are completed (like finishing a checklist goal or earning points).

        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            AchievementManager achievementManager = new AchievementManager(manager);
            string fileName = "goals.txt";

            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("\n--- Eternal Quest Menu ---");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Show Score and Achievements");
                Console.WriteLine("7. Quit");
                Console.Write("Select a choice: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        manager.CreateGoal();
                        break;

                    case "2":
                        manager.DisplayGoals();
                        break;

                    case "3":
                        manager.DisplayGoals();
                        Console.Write("Enter goal number: ");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        int points = manager.RecordEvent(index);
                        Console.WriteLine($"You earned {points} points!");
                        achievementManager.CheckAchievements();
                        break;

                    case "4":
                        manager.SaveGoals(fileName);
                        Console.WriteLine("Goals saved!");
                        break;

                    case "5":
                        manager.LoadGoals(fileName);
                        Console.WriteLine("Goals loaded!");
                        break;

                    case "6":
                        Console.WriteLine($"Total Score: {manager.Score}");
                        achievementManager.ShowAchievements();
                        break;

                    case "7":
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

            Console.WriteLine("Thanks for playing Eternal Quest!");
        }
    }
}
