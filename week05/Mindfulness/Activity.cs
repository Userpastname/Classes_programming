public class Activity
{
    string _startingMessage = "";
    string _endingMessage = "";

    public Activity(string startingMessage, string endingMessage)
    {
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
    }

    public string GetStartingMessage()
    {
        return _startingMessage;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void pauseSpinner(int seconds, string prompt)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("   o   ");
                Console.WriteLine("   o   ");
                Console.WriteLine("   o   ");
            }
            else if (i % 4 == 1)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("      o");
                Console.WriteLine("   o   ");
                Console.WriteLine("o      ");
            }
            else if (i % 4 == 2)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("      ");
                Console.WriteLine("o  o  o");
                Console.WriteLine("      ");
            }
            else if (i % 4 == 3)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("o      ");
                Console.WriteLine("   o   ");
                Console.WriteLine("      o");
            }
            Thread.Sleep(50);
            Console.WriteLine(prompt);
        }
    }

    public void countdown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(Convert.ToString(seconds - i));
            Thread.Sleep(1000);
        }
    }
}