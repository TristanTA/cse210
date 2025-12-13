public class Grid
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name {get; private set;}
    public Dictionary<Guid, int> Blocks {get; private set;}

    public Grid(string name)
    {
        Name = name;
        Blocks = new();
    }
}