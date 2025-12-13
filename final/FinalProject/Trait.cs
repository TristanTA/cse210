abstract public class Trait
{
    public Block Block { get; protected set; }



    protected Trait(Block block)
    {
        Block = block;

        Console.WriteLine(
            $"[Trait Added] Block: {block.Name}, Trait: {GetType().Name}"
        );
    }
    abstract public void Calculate();
    }