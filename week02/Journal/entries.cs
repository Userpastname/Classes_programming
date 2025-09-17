public class Entries
{
    List<string> _entries = new List<string>();

    public void addEntry(string able = "")
    {
        _entries.Add(able);
    }


    public List<string> getEntries()
    {
        return _entries;
    }
}