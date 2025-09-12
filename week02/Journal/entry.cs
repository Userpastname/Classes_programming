public class Entry
{
    public string newEntry(string prompt = null)
    {

        string answer = "";
        answer = Console.ReadLine();

        string Entry = "Entry: " + Convert.ToString(DateTime.Now) + " qeustion: " + prompt + " answer: " + answer;

        return Entry;
    }
}