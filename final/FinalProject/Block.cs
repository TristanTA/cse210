public class Block
{
    private string _name;
    private bool _size;
    private bool _energy;
    private bool _fuel;
    private string _fuelType;
    private bool _thrust;
    private Dictionary<Component, int> _components;
    private float _durability;
    private List<Trait> _traits;

    public Block(string name, bool size, bool energy, bool fuel, string fuelType, bool thrust, Dictionary<Component, int> components)
    {
        _name = name;
        _size = size;
        _energy = energy;
        _fuel = fuel;
        _fuelType = fuelType;
        _thrust = thrust;
        _components = components;
        _durability = Calculate_Durability();
    }

 private void Assign_Traits()
    {
        if (Has_energy())
        {
            Energy energy = new Energy(this);
            _traits.Add(energy);
        }
                if (Has_fuel())
        {
            Fuel fuel = new Fuel(_fuelType, this);
            _traits.Add(fuel);
        }
                if (Has_thrust())
        {
            Thrust thrust = new Thrust(this);
            _traits.Add(thrust);
        }
    }
    private float Calculate_Durability()
    {
        float total_durability = 0;

        foreach (Component comp in _components.Keys)
        {
            int count = _components[comp];
            float part_durability = comp.Get_strength();

            total_durability += count * part_durability;
        }

        return total_durability;
    }
    public string Get_name(){
        return _name;
    }
    public bool Get_size(){
        return _size;
    }
    public bool Has_energy()
    {
        return _energy;
    }
    public bool Has_fuel()
    {
        return _fuel;
    }
    public bool Has_thrust()
    {
        return _thrust;
    }
    public Dictionary<Component, int> Get_components(){
        return _components;
    }
    public void Set_name(string name){
        _name = name;
    }
    public void Set_size(bool size){
        _size = size;
    }
    public void Set_components(Dictionary<Component, int> components){
        _components = components;
    }
}