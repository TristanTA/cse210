using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double entered_number;
        List<double> numbers = new List<double>();
        do
        {
            Console.WriteLine("Please enter a number: ");
            entered_number = double.Parse(Console.ReadLine());
            numbers.Add(entered_number);
        } while (entered_number != 0);
        double sum = numbers.Sum();
        double average = numbers.Average();
        double max = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");
    }
}