using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        bool again = false;
        do
        {


            Random RandomNumber = new Random();
            int number = RandomNumber.Next(1, 11);
            int guess = 0;

            int guesses = 0;

            do
            {
                Console.WriteLine("guess a number between 1 & 100");
                guess = Convert.ToInt32(Console.ReadLine());

                guesses++;

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }

            } while (guess != number);

            Console.WriteLine("You Guessed it!");
            Console.WriteLine("You Guessed " + guesses + " times!");
            Console.WriteLine("Want to play again? (y/n)");
            string willy = Console.ReadLine();
            if (willy == "y")
            {
                again = true;
            }
            else
            {
                again = false;
            }


        } while (again == true);

    }
}