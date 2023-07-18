using System;

class Program
{
    static void Main(string[] args)
    {
        // We added parts 1, 2 and 3 at the end of code/ program with.
         List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        { // We used ToInt32 fro the string with 32-bit integr value.
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = 0;
        int max = int.MinValue;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }

        double average = (double)sum / numbers.Count;

        // The programm print the user input from the below code.

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
}
