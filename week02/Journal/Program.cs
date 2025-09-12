using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Cryptography.X509Certificates;
class Program
{
    
    static void Main(string[] args)
    {
        // Prompt question = new Prompt();
        // string quest = "";
        // quest = question.generator();
        // Console.WriteLine(quest);
        string answer = "";


        string filer = @"C:\Users\paper\Classes_programming\week02\Journal\texterr.txt";
        File.WriteAllText(filer, answer);

        Entries entries= new Entries();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                Prompt question = new Prompt();
                string quester = question.generator();
                Console.WriteLine(quester);
                Entry entery = new Entry();
                string blah = "";
                blah = entery.newEntry(quester);
                entries.addEntry(blah);

            }
            else if (answer == "2")
            {
                List<string> list = new List<string>();
                list = entries.getEntries();
                foreach (string quester in list)
                {
                    Console.WriteLine(quester);
                }
            }
            else if (answer == "3")
            {
                string fissler = Console.ReadLine();
                string abler = @"C:\Users\paper\Classes_programming\week02\Journal\" + fissler;
                string[] aloy = File.ReadAllLines(abler);
                foreach (string quester in aloy)
                {
                    Console.WriteLine(quester);
                }
                
            }
            else if (answer == "4")
            {
                Console.WriteLine("name your file: ");
                string angel = Console.ReadLine();
                string filePath = @"C:\Users\paper\Classes_programming\week02\Journal\" + angel;
                List<string> list = new List<string>();
                list = entries.getEntries();
                File.WriteAllLines(filePath, list);
            }

















        }
        while (answer != "5");

    }


}