using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        double num = 0;


        do
        {
            Console.Write("Enter number: ");
            num = double.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }

        } while (num != 0);

        double sum = numbers.Sum();
        double average = numbers.Average();
        double max = numbers.Max();
        double minPosititve = max;

        // get smallest positive number
        foreach (var number in numbers)
        {
            if (number < minPosititve && number >= 0)
            {
                minPosititve = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {minPosititve}");
        Console.WriteLine("The sorted list is:");

        // print sorted list
        numbers.Sort();
        foreach (double sortedNum in numbers)
        {
            Console.WriteLine(sortedNum);
        }
    }
}