public class Prompt
{
    public string generator()
    {
        List<string> _questions = new List<string>();
        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("What would you change about the way you handled your day?");

        Random random = new Random();
        int _question_number = random.Next(0, 5);

        return _questions[_question_number].ToString();
    }
}