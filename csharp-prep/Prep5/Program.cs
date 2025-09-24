using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        string userName;
        Console.WriteLine("What is your name?");
        userName = Console.ReadLine();
        return userName;
    }
    static float PromptUserNumber()
    {
        float userNumber;
        Console.WriteLine("What is your favorite number?");
        userNumber = float.Parse(Console.ReadLine());
        return userNumber;
    }
    static int PromptUserBirthYear(out int userBirthYear)
    {
        Console.WriteLine("What year were you born?");
        userBirthYear = int.Parse(Console.ReadLine());
        return userBirthYear;
    }
    static float SquareNumber(float number)
    {
        float squaredNumber = number * number;
        return squaredNumber;
    }
    static void DisplayResults(string userName, float squareNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, your squared number is {squareNumber}.");
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        Console.WriteLine($"{userName}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        string userName;
        float userNumber;
        int birthYear;
        float squaredNumber;
        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        PromptUserBirthYear(out birthYear);
        squaredNumber = SquareNumber(userNumber);
        DisplayResults(userName, squaredNumber, birthYear);
    }
}