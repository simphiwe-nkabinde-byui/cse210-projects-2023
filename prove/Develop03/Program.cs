using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        int numberToHide = 0;
        string response = "";
        while (response != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.HideRandomWords(numberToHide);
            string displayText = scripture.GetDisplayText();
            Console.WriteLine(displayText);

            Console.WriteLine(prompt);
            response = Console.ReadLine();
            numberToHide += 3;
        }
    }
}