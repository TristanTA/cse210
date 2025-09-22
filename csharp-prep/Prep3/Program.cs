using System;

class Program
{
    Random randomGenerator = new Random();
    int magicNumber;
    string guessNumber;
    int intGuessNumber;
    public Program()
    {
        magicNumber = randomGenerator.Next(0, 100);
    }
    static void Main(string[] args)
    {
        var obj = new Program();
        do
        {
            Console.WriteLine("What is your guess? ");
            obj.guessNumber = Console.ReadLine();
            obj.intGuessNumber = int.Parse(obj.guessNumber);
            if (obj.intGuessNumber > obj.magicNumber)
            {
                Console.WriteLine("Your guess is too high... ");
            }
            else if (obj.intGuessNumber < obj.magicNumber)
            {
                Console.WriteLine("Your guess is too low...");
            }
        } while (obj.intGuessNumber != obj.magicNumber);

        Console.WriteLine("You guessed the number!");
    }
}