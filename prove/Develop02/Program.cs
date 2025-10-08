using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // Parameters
    public static List<string> journal = new List<string>();
    public static int user_action;
    public static List<string> promptList = new List<string>
    {
        "What made you smile today?",
        "What did you learn today?",
        "Who did you talk to today?"
    };

    // Main
    static void Main(string[] args)
    {
        bool loop_continue = true;
        Entry entry = new Entry();
        FileManager fileManager = new FileManager();

        while (loop_continue)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            user_action = int.Parse(Console.ReadLine());

            if (user_action == 1)
            {
                journal.Add(entry.Write(promptList));
            }
            else if (user_action == 2)
            {
                Console.WriteLine("Display:");
                entry.Display(journal);
            }
            else if (user_action == 3)
            {
                Console.WriteLine("Save:");
                fileManager.Save(journal);
            }
            else if (user_action == 4)
            {
                Console.WriteLine("Load:");
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                journal = fileManager.Load(fileName);
            }
            else if (user_action == 5)
            {
                Console.WriteLine("Exiting. . .");
                loop_continue = false;
            }
            else
            {
                Console.WriteLine("User input not recognized. Input must a number 1-5. Please try again.");
            }
        }
    }
}