public class Thrust : Trait
{
    private float _maxOutput;
    private float _reqOutput;



    public Thrust(Block block) : base(block)
    {
        Calculate();
    }
    override public void Calculate()
    {
        _maxOutput = 0;
        _reqOutput = 0;
    }
}