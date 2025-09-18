using System;
using System.Collections.Generic;

namespace JournalProgram
{
    public class PromptGenerator
    {
        private List<string> _prompts = new List<string>();
        private Random _random = new Random();

        public PromptGenerator()
        {
            _prompts.Add("What was the best thing that happened to you today?");
            _prompts.Add("Who made you smile today?");
            _prompts.Add("What challenge did you face today?");
            _prompts.Add("What are you grateful for?");
            _prompts.Add("If you could change one thing about today, what would it be?");
        }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}

