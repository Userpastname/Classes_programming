public class MathAssignment:Assignment{

    string _textbookSection = "";
    string _problems = "";

    public MathAssignment(string textbookSection, string problems, string studentName, string topic) : base(studentName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public void GetHomeworkList(){
        Console.WriteLine("Section " + _textbookSection + " Problems " + _problems);
    }
}