using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square(5, "blue");
        Rectangle rc = new Rectangle(5, 10, "green");
        Circle cr = new Circle(10, "red");

        List<Shape> shapes = new List<Shape> { sq, rc, cr };

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetColor());
        }
    }
}