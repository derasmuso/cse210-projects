using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        Console.WriteLine("Find the magic number from 1 to 100.");
        int magicNumber = randomGenerator.Next(1, 100);


        int guess = -1;


        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());



            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");

            }
        }

    }
}