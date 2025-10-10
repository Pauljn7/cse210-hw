using System;
using System.Diagnostics;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "Helps you relax by guiding your breathing—clear your mind and focus.")
    { }

    public override void Run()
    {
        Start();
        if (_durationInSeconds == 0)
        {
            Console.Write("Enter duration (seconds): ");
            SetDuration(int.Parse(Console.ReadLine()));
        }

        var sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < _durationInSeconds)
        {
            Console.Write("Inhale... ");
            Countdown(4);
            Console.Write("Hold... ");
            Countdown(2);
            Console.Write("Exhale... ");
            Countdown(4);
            Console.WriteLine();
        }

        End();
    }
}

