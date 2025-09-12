public class Prompt
{
    public string generator()
    {
        List<string> questions = new List<string>();
        questions.Add("Who was the most interesting person I interacted with today?");
        questions.Add("What was the best part of my day?");
        questions.Add("How did I see the hand of the Lord in my life today?");
        questions.Add("What was the strongest emotion I felt today?");
        questions.Add("What would you change about the way you handled your day?");

        Random random = new Random();
        int question_number = random.Next(0, 5);

        return questions[question_number].ToString();
    }
}