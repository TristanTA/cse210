public class Component
{
    private string _name;
    private float _strength;

    public Component(string name, float strength)
    {
        _name = name;
        _strength = strength;
    }
    
    public string Get_name(){
        return _name;
    }
    public float Get_strength(){
        return _strength;
    }
    public void Set_name(string name){
        _name = name;
    }
    public void Set_strength(float strength){
        _strength = strength;
    }
}