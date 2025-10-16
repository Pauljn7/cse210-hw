using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override int RecordEvent()
        {
            if (_isComplete)
            {
                return 0;
            }

            _isComplete = true;
            return Points;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override void Display(int index)
        {
            string status = _isComplete ? "[X]" : "[ ]";
            Console.WriteLine($"{index + 1}. {status} {Name} ({Description})");
        }

        public override string GetString()
        {
            return $"Simple|{Name}|{Description}|{Points}|{_isComplete}";
        }
    }
}

