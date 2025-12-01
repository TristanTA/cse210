public class Block
{
    private string _name;
    private bool _size;
    private Dictionary<Component, int> _components;

    public Block(string name, bool size, Dictionary<Component, int> components)
    {
        _name = name;
        _size = size;
        _components = components;
    }

    public string Get_name(){
        return _name;
    }
    public bool Get_size(){
        return _size;
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