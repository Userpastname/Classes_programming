using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction newOne = new Fraction(1, 1);
        Fraction newTwo = new Fraction(5, 1);
        Fraction newThree = new Fraction(3, 4);
        Fraction newFour = new Fraction(1, 3);

        Console.WriteLine(newOne.Returnfraction());
        Console.WriteLine(Convert.ToString(newOne.Returndecimal()));
        Console.WriteLine(newTwo.Returnfraction());
        Console.WriteLine(Convert.ToString(newTwo.Returndecimal()));
        Console.WriteLine(newThree.Returnfraction());
        Console.WriteLine(Convert.ToString(newThree.Returndecimal()));
        Console.WriteLine(newFour.Returnfraction());
        Console.WriteLine(Convert.ToString(newFour.Returndecimal()));


    }
}