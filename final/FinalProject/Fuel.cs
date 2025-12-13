public class Fuel : Trait
{
    public string FuelType { get; }
    public float ConsumptionRate { get; private set; }

    public Fuel(Block block, string fuelType) : base(block)
    {
        FuelType = fuelType;
        Calculate();
    }

    public override void Calculate()
    {
        if (Block.Name.Contains("Reactor"))
        {
            ConsumptionRate = Block.Size ? 0.1f : 0.03f;
        }
        else if (Block.Name.Contains("Thruster"))
        {
            ConsumptionRate = Block.Size ? 1.2f : 0.4f;
        }
        else
        {
            ConsumptionRate = 0f;
        }
    }
}
