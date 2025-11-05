using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mindfullness!");
        bool cont = true;
        while (cont == true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("Breathing, Reflection, Listing, or Quit");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "breathing")
            {
                Breathing breath = new Breathing();
                breath.Display();
            }
            else if (choice.ToLower() == "reflection")
            {
                Reflection reflect = new Reflection();
                reflect.Display();
            }
            else if (choice.ToLower() == "listing")
            {
                Listing list = new Listing();
                list.Display();
            }
            else if (choice.ToLower() == "quit")
            {
                cont = false;
            }
            else
            {
                Console.WriteLine("Please Enter Valid Response");
            }
        }
    }
}