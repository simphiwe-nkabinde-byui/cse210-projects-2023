using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string option = "";

        do
        {
            option = getMenuPrompt();
            switch (option)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.getRandomPrompt();

                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();
                    string dateText = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(dateText, prompt, entryText);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    if (loadFilename.length)
                    {
                        journal.LoadFromFile(loadFilename);
                    }
                    break;
                case "4":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    if (saveFilename.length)
                    {
                        journal.SaveToFile(saveFilename);
                    }
                    break;
                default:
                    break;
            }
        } while (option != "5");


    }

    static string getMenuPrompt()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        return Console.ReadLine();
    }
}