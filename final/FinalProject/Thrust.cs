public class Thrust : Trait
{
    public float MaxOutput { get; private set; }
    public float RequiredEnergy { get; private set; }

    public Thrust(Block block) : base(block)
    {
        Calculate();
    }

    public override void Calculate()
    {
        if (Block.Size) // large grid
        {
            MaxOutput = 600_000f;
            RequiredEnergy = 4.0f;
        }
        else // small grid
        {
            MaxOutput = 80_000f;
            RequiredEnergy = 0.6f;
        }
    }
}
