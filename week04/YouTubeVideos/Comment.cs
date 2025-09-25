using System.Net;
using System.Runtime.CompilerServices;

public class Comment
{
    string _author = "";
    string _text = "";


    public Comment()
    {

    }
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetText()
    {
        return _text;
    }
}