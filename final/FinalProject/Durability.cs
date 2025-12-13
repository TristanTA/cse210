public class Durability : Trait
{
    public float HitPoints { get; private set; }

    public Durability(Block block) : base(block)
    {
        Calculate();
    }

    public override void Calculate()
    {
        int componentCount = 0;

        foreach (var kvp in Block.Components)
        {
            componentCount += kvp.Value;
        }

        HitPoints = componentCount * (Block.Size ? 25f : 5f);
    }
}
