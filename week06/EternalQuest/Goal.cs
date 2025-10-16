using System;

namespace EternalQuest
{
    // Base class for all goal types
    public abstract class Goal
    {
        private string _name;
        private string _description;
        private int _points;

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int Points { get { return _points; } }

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract int RecordEvent();
        public abstract bool IsComplete();
        public abstract void Display(int index);
        public abstract string GetString();
    }
}

