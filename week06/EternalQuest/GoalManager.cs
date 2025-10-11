using Microsoft.VisualBasic;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    public void Start()
    {
        string input = "";

        while (input != "exit")
        {
            Console.WriteLine("what would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("1. display info");
            Console.WriteLine("2. list goal names");
            Console.WriteLine("3. list goal details");
            Console.WriteLine("4. create goal");
            Console.WriteLine("5. record event");
            Console.WriteLine("6. save goals");
            Console.WriteLine("7. load goals");
            Console.WriteLine("");
            Console.WriteLine("type exit to exit");
            input = Console.ReadLine();

            if (input == "1")
            {
                DisplayPlayerInfo();
            }
            else if (input == "2")
            {
                ListGoalNames();
            }
            else if (input == "3")
            {
                ListGoalDetails();
            }
            else if (input == "4")
            {
                CreateGoal();
            }
            else if (input == "5")
            {
                RecordEvent();
            }
            else if (input == "6")
            {
                SaveGoals();
            }
            else if (input == "7")
            {
                LoadGoals();
            }
        }


        

    }

    public void DisplayPlayerInfo()
    {
        int total = 0;
        foreach (Goal goal in _goals)
        {
                total += goal.GetPoints();
        }
        Console.WriteLine(Convert.ToString(total));
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.getName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        string input = "";
        string name = "";
        string description = "";
        int min = 0;
        Console.WriteLine("what type of goal do you want to Create?");
        Console.WriteLine("");
        Console.WriteLine("1. Simple: goal is either complete or not complete");
        Console.WriteLine("2. Eternal: goal is never complete, you just tally an instance you have met it (for habit goals)");
        Console.WriteLine("3. Checklist: goal completes after checklist amount is met");
        Console.WriteLine("");
        Console.WriteLine("insert number");
        Console.WriteLine("press enter to cancel");

        input = Console.ReadLine();

        /*
            asks the user the amount of time it will take them and adjusts the amount of points that will be rewarded
        */


        if (input == "1")
        {
            Console.WriteLine("name the goal:");
            name = Console.ReadLine();
            Console.WriteLine("give a description (requirements to complete)");
            description = Console.ReadLine();
            Console.WriteLine("(combined) how long (in minutes) will it take you to complete");
            min = Convert.ToInt16(Console.ReadLine());

            _goals.Add(new SimpleGoal(name, description, min));
        }
        else if (input == "2")
        {
            Console.WriteLine("name the goal:");
            name = Console.ReadLine();
            Console.WriteLine("give a description (requirements to complete)");
            description = Console.ReadLine();
            Console.WriteLine("how long (in minutes) will it take you to complete each time");
            min = Convert.ToInt16(Console.ReadLine());

            _goals.Add(new EternalGoal(name, description, min));
        }
        else if (input == "3")
        {
            int times = 0;
            Console.WriteLine("name the goal:");
            name = Console.ReadLine();
            Console.WriteLine("give a description (requirements to complete)");
            description = Console.ReadLine();
            Console.WriteLine("(combined) how long (in minutes) will it take you to complete");
            min = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("give a number amount of times to complete it");
            times = Convert.ToInt16(Console.ReadLine());

            double mini = 0;
            double bonus = 0;

            bonus = Math.Round((double)min / 2, 0);
            mini = Math.Round(((double)min / 2) / times, 0);

            _goals.Add(new ChecklistGoal(times, (int)bonus, name, description, (int)mini));
        }

    }

    public void RecordEvent()
    {
        int input = 0;
        Console.WriteLine("which goal have you milestoned?");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine(Convert.ToString(i + 1) +". "+ _goals[i].getName());
        }
        input = Convert.ToInt16(Console.ReadLine());
        _goals[input - 1].RecordEvent();
    }

    public void SaveGoals()
    {
        List<string> gaols = new List<string>();
        foreach (Goal goal in _goals)
        {
            gaols.Add(goal.GetStringRepresentation());
        }
        File.AppendAllLines(@"C:\Users\paper\Classes_programming\week06\EternalQuest\goals.txt", gaols);
        Console.WriteLine("goals saved");
        Console.ReadKey();
    }

    public void LoadGoals()
    {

        string[] list = File.ReadAllLines(@"C:\Users\paper\Classes_programming\week06\EternalQuest\goals.txt");

        foreach (string listed in list){
            Console.WriteLine(listed);
        }
    }
}