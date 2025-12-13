using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<Guid, Component> components = new();
        Dictionary<Guid, Block> blocks = new();
        Dictionary<Guid, Grid> grids = new();
        
        Grid ship = new Grid("Main Grid");
        grids.Add(ship.Id, ship);

        foreach (var line in File.ReadAllLines("component_list.csv"))
        {
            string[] parts = line.Split(',');
            string name = parts[0];
            float strength = float.Parse(parts[1]);

            Component component = new Component(Guid.Empty, name, strength);
            components.Add(component.Id, component);
        }

        foreach (string line in File.ReadAllLines("block_list.csv"))
        {
            string[] parts = line.Split(',');
            string blockName = parts[0];
            bool size = bool.Parse(parts[1]);

            Block block = new Block(ship.Id, blockName, size);
            blocks.Add(block.Id, block);
            ship.Blocks.Add(block.Id, 1);

            string[] blockComponents = parts[2].Split('|');

            foreach (string comp in blockComponents)
            {
                string[] split = comp.Split(':');
                string compName = split[0].Trim();
                int count = int.Parse(split[1]);
            Component component = FindComponentByName(components, compName);
            block.Components.Add(component.Id, count);
            }
            foreach (Trait trait in block.Traits)
            {
                trait.Calculate();
            }
        }

        Console.WriteLine("Loaded:");
        Console.WriteLine($"Grids: {grids.Count}");
        Console.WriteLine($"Blocks: {blocks.Count}");
        Console.WriteLine($"Components: {components.Count}");
    }

    private static Component FindComponentByName(
        Dictionary<Guid, Component> components,
        string name)
    {
        foreach (Component c in components.Values)
        {
            if (c.Name == name)
                return c;
        }

        throw new Exception($"Component not found: {name}");
    }
}