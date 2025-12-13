public class Energy : Trait
{
    public float MaxOutput { get; private set; }
    public float RequiredInput { get; private set; }

    public Energy(Block block) : base(block)
    {
        Calculate();
    }

    public override void Calculate()
    {
        if (Block.Name.Contains("Battery"))
        {
            MaxOutput = Block.Size ? 12.0f : 4.0f;
            RequiredInput = 0f;
        }
        else if (Block.Name.Contains("Reactor"))
        {
            MaxOutput = Block.Size ? 15.0f : 5.0f;
            RequiredInput = 0f;
        }
        else
        {
            MaxOutput = 0f;
            RequiredInput = Block.Size ? 2.0f : 0.5f;
        }
    }
}
