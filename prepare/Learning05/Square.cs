class Square : Shape
{
    // Attributes
    private double _side;

    // Behaviors
    public Square(double side, string color) : base(color)
    {
        _side = side;
        _color = color;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}