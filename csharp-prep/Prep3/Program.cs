using System;

class Program
{
    static void Main(string[] args)
    {   // For part 3 we used random number
         Random random = new Random();
        int magicNumber = random.Next(1, 101);

       // For part 1 and 2 user call fro number..
       // Console.Write("What is the magic number? ");
        //int userNumber = int.Parse(Console.ReadLine());

        if (userNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (userNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        while (userNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
