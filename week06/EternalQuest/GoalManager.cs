using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public int Score { get { return _score; } }

        public void CreateGoal()
        {
            Console.WriteLine("What kind of goal do you want to create?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter description: ");
            string desc = Console.ReadLine();

            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            if (choice == "1")
            {
                _goals.Add(new SimpleGoal(name, desc, points));
            }
            else if (choice == "2")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (choice == "3")
            {
                Console.Write("Times required: ");
                int required = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, desc, points, required, bonus));
            }
        }

        public void DisplayGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                _goals[i].Display(i);
            }
        }

        public int RecordEvent(int index)
        {
            if (index >= 0 && index < _goals.Count)
            {
                int earned = _goals[index].RecordEvent();
                _score += earned;
                return earned;
            }

            return 0;
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter output = new StreamWriter(filename))
            {
                output.WriteLine(_score);
                foreach (Goal g in _goals)
                {
                    output.WriteLine(g.GetString());
                }
            }
        }

        public void LoadGoals(string filename)
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "Simple")
                {
                    bool done = bool.Parse(parts[4]);
                    SimpleGoal g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (done) g.RecordEvent(); // mark as done
                    _goals.Add(g);
                }
                else if (type == "Eternal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "Checklist")
                {
                    ChecklistGoal g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                    for (int j = 0; j < int.Parse(parts[4]); j++) g.RecordEvent();
                    _goals.Add(g);
                }
            }
        }

        public List<Goal> GetGoals()
        {
            return _goals;
        }
    }
}

