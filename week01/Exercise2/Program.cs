using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = Convert.ToInt32(Console.ReadLine());

        string gradeLetter = "";

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }


        Console.WriteLine("You Got a " + gradeLetter + "!");
        if (gradeLetter == "A" || gradeLetter == "B" || gradeLetter == "C")
        {
            Console.Write("you have gotten 70% or more so you have");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" PASSED");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the course");
        }

    }
}