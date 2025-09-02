using System;
using System.Reflection.Metadata.Ecma335;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome!");
    }
    static string PromptUserName()
    {
        Console.Write("whats your user name?: ");

        string jam = Console.ReadLine();
        return jam;
    }

    static int PromptUserNumber()
    {
        Console.Write("Whats your favourite number?: ");
        int numer = Convert.ToInt16(Console.ReadLine());
        return numer;
    }

    static int SquareNumber(int bass)
    {
        int square = (int)Math.Pow(bass,2);
        return square;
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();

        int number = PromptUserNumber();

        Console.WriteLine(name + ", the square of your number is: " + SquareNumber(number));


    }
}