using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity= new BreathingActivity();
        ListingActivity listingActivity= new ListingActivity();
        ReflectionActivity reflectionActivity= new ReflectionActivity();

        string input = "";
        do
        {
            Console.WriteLine("Choose an activity");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflection");
            input = Console.ReadLine();

            if (input == "1")
            {
                breathingActivity.RunProgram();
            }
            else if (input == "2") {
                listingActivity.RunProgram();
            }
            else if (input == "3") {
                reflectionActivity.RunProgram();
            }
         

        } while (input != "exit");


    }
}