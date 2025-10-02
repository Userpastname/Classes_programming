public class BreathingActivity : Activity
{
    public BreathingActivity(string startingMessage = "Welcome to breathing excircises", string endingMessage = "Thanks for participating") : base(startingMessage, endingMessage)
    {

    }

    public void RunProgram()
    {
        Console.WriteLine(GetStartingMessage());
        Thread.Sleep(1000);
        Console.WriteLine("starting in...");
        countdown(3);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("breathe in");
            countdown(7);
            Console.WriteLine("breathe out");
            countdown(10);
        }
        Console.WriteLine(GetEndingMessage());
    }
}