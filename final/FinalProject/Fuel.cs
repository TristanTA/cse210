public class Fuel : Trait
{
    private string _fuel;
    private float _toDrain;
    private float _toFill;


    public Fuel(string fuel, Block block) : base(block)
    {
        _fuel = fuel;
        Calculate();
    }

    public override void Calculate()
    {
        _toDrain = 0;
        _toFill = 0;
    }
}