using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("17 Dec 2023", 30, 5);
        Swimming swimming = new Swimming("19 Dec 2023", 35, 50);
        Cycling cycling = new Cycling("23 Dec 2023", 45, 60);

        List<Activity> activities = new List<Activity>() { running, swimming, cycling };

        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}