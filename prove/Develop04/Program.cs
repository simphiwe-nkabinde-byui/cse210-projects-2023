using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = GetMenuChoice();
        while (choice != 4)
        {
            Activity activity = new Activity();
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                default:
                    return;
            }
            activity.DisplayStartingMessage();
            activity.Run();
            activity.DisplayEndingMessage();
            choice = GetMenuChoice();
        };
    }

    public static int GetMenuChoice()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = Int32.Parse(Console.ReadLine());
        return choice;
    }
}