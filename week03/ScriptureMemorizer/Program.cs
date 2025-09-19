using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        List<List<string>> reference = new List<List<string>>();
        List<string> script = new List<string>();

        List<Scripture> Scripture = new List<Scripture>();

        string[] strings = File.ReadAllLines("C:/Users/paper/Classes_programming/week03/ScriptureMemorizer/scriptures.txt");
        for (int i = 0; i < strings.Length; i++)
        {
            if ((i+1) % 2 == 1)
            {
                string[] splitted = strings[i].Split(" ");
                List<string> list = new List<string>();
                for (int j = 0; j < splitted.Length; j++)
                {
                    list.Add(splitted[j]);
                }
                reference.Add(list);
            }
            else if ((i+1) % 2 == 0)
            {
                script.Add(strings[i]);
            }
        }

        for (int i = 0; i < reference.Count; i++)
        {
            if (reference[i].Count == 3)
            {
                Reference reference1 = new Reference(reference[i][0], Convert.ToInt32(reference[i][1]), Convert.ToInt32(reference[i][2]));
                Scripture scripture1 = new Scripture(reference1, script[i]);
                Scripture.Add(scripture1);
            }
            else if (reference[i].Count == 4)
            {
                Reference reference1 = new Reference(reference[i][0], Convert.ToInt32(reference[i][1]), Convert.ToInt32(reference[i][2]), Convert.ToInt32(reference[i][3]));
                Scripture scripture1 = new Scripture(reference1, script[i]);
                Scripture.Add(scripture1);
            }
        }

        Random random = new Random();
        int scriptureNum = random.Next(0, Scripture.Count);

        Scripture Scripture1= Scripture[scriptureNum];

        string input = "";
        while (input != "exit")
        {
            Console.WriteLine(Scripture1.GetDisplayText());
            Console.WriteLine("press enter or type exit");
            input = Console.ReadLine();
            if (Scripture1.isAllHidden() == false)
            {
                if (input == "")
                {
                    Scripture1.HideRandomWords(2);
                }
            }
            else
            {
                input = "exit";
            }

        }
    }




}