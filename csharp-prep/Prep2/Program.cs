using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";
        string sign = "";

        // letter
        Console.Write("Grade: ");
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // sign
        if (grade < 97 && grade >= 60)
        {
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 <= 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Grade: {letter}{sign}");

        //pass or fail
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, You've passed");
        }
        else
        {
            Console.WriteLine("You failed. Try harder next time?");
        }
    }
}