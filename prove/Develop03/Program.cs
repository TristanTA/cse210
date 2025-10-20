using System;

public class Program
{
    public void Main(string[] args)
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
            var key = Console.ReadKey(intercept: true);
            if (user_input == "quit")
            {
                continue_program = false;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Hiding Wod...");
                scrip.HideRandomVerseText();
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }
    }
}