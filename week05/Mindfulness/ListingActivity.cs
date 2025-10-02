using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    string[] _strings = { "List the people you love", "List the things you did today", "List your favourite excircises" };

    List<string> _items = new List<string>();

    bool _isOver = false;

    public ListingActivity(string startingMessage = "Welcome to listing activity", string endingMessage = "Thanks for participating") : base(startingMessage, endingMessage)
    {

    }

    public void RunProgram()
    {
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine(GetRandomPrompt());
        countdown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(20);
        _isOver = false;
        do
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                _items.Add(Console.ReadLine());
            }
            else
            {
                _isOver = true;
            }
        } while (_isOver == false);

        ReturnListLength(_items);
        Console.WriteLine(GetEndingMessage());
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string randomString = _strings[random.Next(0, _strings.Length)];
        return randomString;
    }

    public void ReturnListLength(List<string> list)
    {
        Console.WriteLine("you provided " + list.Count + " items, good job!");
    }

}