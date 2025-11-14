class Circle : Shape
{
    // Attributes
    private double _radius;

    // Behaviors
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
        _color = color;
    }
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}