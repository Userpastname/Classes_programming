public class Assignment{
    string _studentName = "";
    string _topic = "";

    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    public void GetSummary(){
        Console.WriteLine(_studentName + " - " + _topic);
    }
}