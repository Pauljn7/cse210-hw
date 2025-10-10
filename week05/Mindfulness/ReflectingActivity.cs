using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time you helped someone in need.",
        "Recall when you overcame a difficult challenge.",
        "Think of a time you made a difference."
    };

    private List<string> _followUps = new()
    {
        "Why was this meaningful?",
        "What did you learn from it?",
        "How can you apply that lesson today?"
    };

    public ReflectingActivity() : base(
        "Reflecting Activity",
        "Guides you to reflect on meaningful moments of growth or kindness.")
    { }

    public override void Run()
    {
        Start();
        if (_durationInSeconds == 0)
        {
            Console.Write("Enter duration (seconds): ");
            SetDuration(int.Parse(Console.ReadLine()));
        }

        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.Write("Press Enter when ready... ");
        Console.ReadLine();

        var sw = Stopwatch.StartNew();
        int i = 0;
        while (sw.Elapsed.TotalSeconds < _durationInSeconds)
        {
            Console.WriteLine($"> {_followUps[i % _followUps.Count]}");
            Countdown(6);
            Console.WriteLine();
            i++;
        }

        End();
    }
}

