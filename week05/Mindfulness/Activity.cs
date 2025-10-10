using System;
using System.Diagnostics;
using System.Threading;

public abstract class Activity
{
    protected string _activityName { get; private set; }
    protected string _description { get; private set; }
    protected int _durationInSeconds { get; private set; }

    protected Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void SetDuration(int seconds)
    {
        _durationInSeconds = seconds > 0 ? seconds : 0;
    }

    public virtual void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_activityName} ---\n{_description}\n");
        PauseWithAnimation(3);
    }

    public virtual void End()
    {
        Console.WriteLine($"\nGood job! You completed {_durationInSeconds} seconds of {_activityName}.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        var spinner = new[] { "\\", "|", "/", "-" };
        var sw = Stopwatch.StartNew();
        int i = 0;
        while (sw.Elapsed.TotalSeconds < seconds)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public abstract void Run();
}

