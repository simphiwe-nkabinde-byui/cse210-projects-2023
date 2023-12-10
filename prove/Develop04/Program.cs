using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = Int32.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                BreathingActivity activity1 = new BreathingActivity();
                activity1.DisplayStartingMessage();
                activity1.Run();
                activity1.DisplayEndingMessage();
                break;
            case 2:
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.DisplayStartingMessage();
                activity2.Run();
                activity2.DisplayEndingMessage();
                break;
            case 3:
                ListingActivity activity3 = new ListingActivity();
                break;
            case 4:
                break;
            default:
                break;
        }
    }
}