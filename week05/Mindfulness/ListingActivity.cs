using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "List people you appreciate:",
        "List your personal strengths:",
        "List things that make you happy:",
        "List goals you’re proud of achieving:"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "Prompts you to list positive thoughts or ideas within the time limit.")
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
        Console.Write("Starting in: ");
        Countdown(5);
        Console.WriteLine("\nBegin listing:");

        var responses = new List<string>();
        var sw = Stopwatch.StartNew();

        while (sw.Elapsed.TotalSeconds < _durationInSeconds)
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                    responses.Add(item);
            }
            Thread.Sleep(100);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        End();
    }
}

