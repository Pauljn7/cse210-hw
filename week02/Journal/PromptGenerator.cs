using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best thing that happened to you today?",
        "What is something you are grateful for?",
        "What did you learn today?",
        "Who made your day better today?",
        "What is one goal you have for tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}
