class Rectangle : Shape
{
    // Attributes
    private double _side;
    private double _length;

    // Behaviors
    public Rectangle(double side, double length, string color) : base(color)
    {
        _side = side;
        _length = length;
        _color = color;
    }
    public override double GetArea()
    {
        return _side * _length;
    }
}