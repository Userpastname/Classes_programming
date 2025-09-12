public class Entries
{
    List<string> entries = new List<string>();

    public void addEntry(string able = "")
    {
        entries.Add(able);
    }


    public List<string> getEntries()
    {
        return entries;
    }
}