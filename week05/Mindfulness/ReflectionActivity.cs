using Microsoft.VisualBasic;

public class ReflectionActivity : Activity
{
    string[] _prompts = { "Think of a time you were selfless", "Think of a time you were brave", "Think of a time you were blessed" };
    string[] _questions = { "How was this experience meaningful to you?", "Were there people involved? If so, who?", "What makes the experience worth reflecting?", "Would you change what happened?", "Where were you and what happened?" };

    List<string> _strings= new List<string>();
    bool _already = false;
    public ReflectionActivity(string startingMessage = "Welcome to listing activity", string endingMessage = "Thanks for participating") : base(startingMessage, endingMessage)
    {

    }

    public void RunProgram()
    {
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine(GetRandomPrompt());
        pauseSpinner(3);

        for (int i = 0; i < 3; i++)
        {
            string questionss = GetRandomPrompt();
            do
            {
                _already = false;
                foreach (string question in _questions)
                {
                    if (questionss == question)
                    {
                        _already = true;
                    }
                }
            } while (_already == true);

            Console.WriteLine(questionss);
            pauseSpinner(3);
            Console.WriteLine(questionss);
            Console.ReadLine();
        }

        Console.WriteLine(GetEndingMessage());

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int prompt = 0;
        prompt = random.Next(0, _prompts.Length);
        return _prompts[prompt];
    }

    public string getRandomPromptQuestion()
    {
        Random random = new Random();
        int question = 0;
        question = random.Next(0, _questions.Length);
        return _questions[question];
    }
}