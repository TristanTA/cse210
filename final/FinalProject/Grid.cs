public class Grid
{
    private string _name;
    private Dictionary<Block, int> _blocks;



    public string Get_name(){
        return _name;
    }
    public Dictionary<Block, int> Get_blocks(){
        return _blocks;
    }
    public void Set_name(string name){
        _name = name;
    }
    public void Set_blocks(Dictionary<Block, int> blocks){
        _blocks = blocks;
    }
}