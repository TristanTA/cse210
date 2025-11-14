abstract class Shape
{
    // Attributes
    protected string _color;

    // Behaviors
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    virtual public double GetArea()
    {
        return 0.0;
    }
}