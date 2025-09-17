public class Entry
{
    public string newEntry(string prompt = null)
    {

        string _answer = "";
        _answer = Console.ReadLine();

        string Entry = "Entry: " + Convert.ToString(DateTime.Now) + " qeustion: " + prompt + " answer: " + _answer;

        return Entry;
    }
}