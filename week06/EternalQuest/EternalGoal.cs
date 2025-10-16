using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            // Always gives points, never completes
            return Points;
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override void Display(int index)
        {
            Console.WriteLine($"{index + 1}. [∞] {Name} ({Description})");
        }

        public override string GetString()
        {
            return $"Eternal|{Name}|{Description}|{Points}";
        }
    }
}

