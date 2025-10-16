using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2025, 10, 15), 30, 5.0),
                new Cycling(new DateTime(2025, 10, 14), 45, 20.0),
                new Swimming(new DateTime(2025, 10, 13), 25, 40)
            };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
