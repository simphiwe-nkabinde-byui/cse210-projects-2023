using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";

        do
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"{guessCount} guesses");

                    Console.WriteLine("Do you want to play again?");
                    playAgain = Console.ReadLine();
                }

            } while (guess != magicNum);

        } while (playAgain == "yes");




    }
}