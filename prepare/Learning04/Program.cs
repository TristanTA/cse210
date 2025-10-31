using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Samuel Bennet", "Multiplication", "Section 7.3", "Problems 8-19");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("Samuel Bennet", "Multiplication", "European History");
        Console.WriteLine(write.GetWritingInformation());
    }
}