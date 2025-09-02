using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        List<int> inter = new List<int>();
        do
        {
            Console.WriteLine("Give me a number (press 0 to end the loop)");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess != 0)
            {
                inter.Add(guess);
            }

        } while (guess != 0);
        int total = 0;
        int avg = 0;
        int largest = 0;

        foreach (int i in inter)
        {
            total += i;
        }

        avg = total / inter.Count();

        largest = inter.Max();

        Console.WriteLine(total + " is the sum");
        Console.WriteLine(avg + "is the average");
        Console.WriteLine(largest + "is the largest");

    }
}