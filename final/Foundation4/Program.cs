using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity run = new Running(new DateTime(2026, 3, 3), 30, 3.0);
        Activity bike = new Cycling(new DateTime(2026, 3, 4), 45, 15.0);
        Activity swim = new Swimming(new DateTime(2026, 3, 5), 40, 30);

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}