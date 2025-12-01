public class Energy : Trait
{
    private float _toFill;
    private float _toDrain;
    private float _maxOutput;
    private float _reqOutput;



    public Energy(Block block) : base(block)
    {
        Calculate();
    }
    override public void Calculate()
    {
        _toFill = 0;
        _toDrain = 0;
        _maxOutput = 0;
        _reqOutput = 0;
    }
}