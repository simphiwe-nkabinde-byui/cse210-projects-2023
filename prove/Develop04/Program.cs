using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Listing Activity");
        Console.WriteLine("3. Start Reflecting Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = Int32.Parse(Console.ReadLine());

        Activity activity;

        switch (choice)
        {
            case 1:
                BreathingActivity activit = new BreathingActivity();
                activit.DisplayStartingMessage();
                activit.Run();
                activit.DisplayEndingMessage();

                break;
            case 2:
                activity = new ListingActivity();
                break;
            case 3:
                activity = new ReflectingActivity();
                break;
            case 4:
                break;
            default:
                break;
        }
    }
}