using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(one.GetTop());
        Console.WriteLine(one.GetBottom());
        one.SetTop(6);
        one.SetBottom(36);
        Console.WriteLine(one.GetFractionString());

        Fraction two = new Fraction(5);
        Console.WriteLine(two.GetFractionString());

        Fraction three = new Fraction(5, 10);
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDecimalValue());
    }

   
}