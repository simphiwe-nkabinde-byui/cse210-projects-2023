using System;

class Program
{
    static void Main(string[] args)
    {
        string[] lectureData = System.IO.File.ReadAllLines("lectureEvent.txt");
        string[] receptionData = System.IO.File.ReadAllLines("ReceptionEvent.txt");
        string[] outdoorData = System.IO.File.ReadAllLines("OutdoorEvent.txt");

        Lecture lectureEvent = new Lecture(lectureData[0].Split(","));
        Reception receptionEvent = new Reception(receptionData[0].Split(","));
        OutdoorGathering outdoorEvent = new OutdoorGathering(outdoorData[0].Split(","));

        List<Event> events = new List<Event>() { lectureEvent, receptionEvent, outdoorEvent };

        foreach (Event e in events)
        {
        string standardDetails = e.GetStandardDetails();
            string fullDetails = e.GetFullDetails();
            string shortDescription = e.GetShortDescription();
            
            Console.WriteLine("\n\nStandard Details:");
            Console.WriteLine(standardDetails);
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(fullDetails);
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(shortDescription);
        }
    }
}