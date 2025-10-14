using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Swimming swimming = new Swimming(13, 5);
        Running running = new Running(45, 5);
        Cycling cycling = new Cycling(80, 4);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}