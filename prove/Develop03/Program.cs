using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Automatic Scripture Memory Game");
        Reference ref1 = new Reference("John", 11, 35);
        Scripture scrip = new Scripture("Jesus Wept.");
        bool continue_program = true;
        while (continue_program == true)
        {
            Console.WriteLine("Press enter to continue, type quit to leave.");
            Console.WriteLine(scrip.GetVerseString());
            string user_input = Console.ReadLine();
            if (user_input == "quit")
            {
                continue_program = false;
            }
            else if (string.IsNullOrEmpty(user_input))
            {
                Console.WriteLine("Hiding Word...");
                scrip.HideRandomVerseText();
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }
    }
}