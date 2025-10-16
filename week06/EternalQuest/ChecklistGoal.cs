using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _timesDone;
        private int _timesRequired;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int timesRequired, int bonus)
            : base(name, description, points)
        {
            _timesDone = 0;
            _timesRequired = timesRequired;
            _bonus = bonus;
        }

        public override int RecordEvent()
        {
            if (_timesDone < _timesRequired)
            {
                _timesDone++;

                if (_timesDone == _timesRequired)
                {
                    Console.WriteLine($"You completed the checklist! Bonus {_bonus} points!");
                    return Points + _bonus;
                }

                return Points;
            }

            return 0;
        }

        public override bool IsComplete()
        {
            return _timesDone >= _timesRequired;
        }

        public override void Display(int index)
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{index + 1}. {status} {Name} ({Description}) -- Completed {_timesDone}/{_timesRequired}");
        }

        public override string GetString()
        {
            return $"Checklist|{Name}|{Description}|{Points}|{_timesDone}|{_timesRequired}|{_bonus}";
        }
    }
}

