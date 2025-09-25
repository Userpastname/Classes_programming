using System.Dynamic;
using Microsoft.VisualBasic;

public class Video
{
    string _title = "";
    string _author = "";
    int _length = 0;

    List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void getVideo()
    {
        Console.WriteLine("title: "+_title + ", Author: " + _author + ", Length: " + _length + "s");
    }
    public void GetComments()
    {
        Console.WriteLine("comments:");
        for (int i = 0; i < _comments.Count; i++)
        {
            Console.WriteLine(Convert.ToString(i + 1) + ". " + _comments[i].GetAuthor());
            Console.WriteLine(_comments[i].GetText());
        }
    }

}