public class Component
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name {get; private set;}
    public float Strength {get; private set;}
    public Guid BlockId { get; private set; }


    public Component(Guid blockid, string name, float strength)
    {
        BlockId = blockid;
        Name = name;
        Strength = strength;
    }
}