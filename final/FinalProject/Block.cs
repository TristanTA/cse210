public class Block
{
    public Guid Id {get; private set;} = Guid.NewGuid();
    public string Name {get; private set;}
    public bool Size {get; private set;}
    public Dictionary<Guid, int> Components {get; private set;}
    public Guid GridId {get; private set;}
    public List<Trait> Traits {get; private set;} = new();


    public Block(Guid gridid, string name, bool size)
    {
        GridId = gridid;
        Name = name;
        Size = size;
        Components = new();
        Traits.AddRange(TraitFactory.CreateTraits(this));

    }
    private static class TraitFactory
    {
        public static List<Trait> CreateTraits(Block block)
        {
            List<Trait> traits = new List<Trait>();

            switch (block.Name)
            {
                case "Battery":
                    traits.Add(new Energy(block));
                    break;

                case "Reactor":
                    traits.Add(new Energy(block));
                    traits.Add(new Fuel(block, "Uranium"));
                    break;

                case "AtmosphericThruster":
                    traits.Add(new Thrust(block));
                    traits.Add(new Energy(block));
                    break;

                case "HydrogenThruster":
                    traits.Add(new Thrust(block));
                    traits.Add(new Fuel(block, "Hydrogen"));
                    break;
            }

            traits.Add(new Durability(block));

            return traits;
        }
    }
}