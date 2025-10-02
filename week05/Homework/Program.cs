using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("1.5", "1-3", "miles wendler", "math");
        mathAssignment.GetSummary();
        mathAssignment.GetHomeworkList();
        WritingAssignment writingAssignment = new WritingAssignment("How to do nothing", "miles wendler", "english");
        writingAssignment.GetSummary();
        writingAssignment.getWritingInformation();
    }
}