public class Durability : Trait
{
    private float _durability;



    public Durability(Block block) : base(block)
    {
        Calculate();
    }
    override public void Calculate()
    {
        _durability = 0;
    }
}