using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Component> component_dict = new Dictionary<string, Component>();
        string[] components = File.ReadAllLines("component_list.csv");
        foreach (string line in components)
        {
            string[] parts = line.Split(',');
            string name = parts[0];
            float strength = float.Parse(parts[1]);
            Component c = new Component(name, strength);
            component_dict.Add(name, c);
        }
        Console.WriteLine(component_dict);

        Dictionary<string, Block> block_dict = new Dictionary<string, Block>();
        string[] blocks = File.ReadAllLines("block_list.csv");
        foreach (string line in blocks)
        {
            string[] parts = line.Split(',');
            string name = parts[0];
            bool size = bool.Parse(parts[1]);
            string componentsField = parts[2];
            
            string[] block_components = parts[2].Split('|');
            Dictionary<Component, int> comp_dict = new Dictionary<Component, int>();
            foreach (string comp in block_components)
            {
                string[] split_comp = comp.Split(":");
                string comp_name = split_comp[0].Trim().Trim('"');
                Component comp_obj = component_dict[comp_name];
                int comp_count = int.Parse(split_comp[1].Trim().Trim('"'));
                comp_dict.Add(comp_obj, comp_count);
            }
            
            Block b = new Block(name, size, comp_dict);
        }
        Console.WriteLine(block_dict);
    }
}