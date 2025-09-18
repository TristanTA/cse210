using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        float gradeFloat = int.Parse(gradePercent);
        string letter = "";
        if (gradeFloat >= 0 && gradeFloat <= 59)
        {
            Console.WriteLine("Your grade is F");
            letter = "F";
        }
        else if (gradeFloat >= 60 && gradeFloat <= 69)
        {
            Console.WriteLine("Your grade is D");
            letter = "D";
        }
        else if (gradeFloat >= 70 && gradeFloat <= 79)
        {
            Console.WriteLine("Your grade is C");
            letter = "C";
        }
        else if (gradeFloat >= 80 && gradeFloat <= 89)
        {
            Console.WriteLine("Your grade is B");
            letter = "B";
        }
        else if (gradeFloat >= 90 && gradeFloat <= 100)
        {
            Console.WriteLine("Your grade is A");
            letter = "A";
        }
        if (gradeFloat >= 70)
        {
            Console.WriteLine("You have passed the Class!");
        }
        else
        {
            Console.WriteLine("Annnnnnd you failed...");
        }

        Console.WriteLine($"Grade: {letter}");

        
    }
}