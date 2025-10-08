using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // Parameters
    public static List<string> journal;
    public static int user_action;
    public static List<string> promptList;

    // Main
    static void Main(string[] args)
    {
        bool loop_continue = true;
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
                Entry entry = new Entry();
                entry.Write(promptList);
            }
            else if (user_action == 2)
            {
                Entry entry = new Entry();
                entry.Display(journal);
            }
            else if (user_action == 3)
            {
                // call save
            }
            else if (user_action == 4)
            {
                // call load
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