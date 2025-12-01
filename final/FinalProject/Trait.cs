abstract public class Trait
{
    protected Block _block;


    public Trait(Block block)
    {
        _block = block;
    }
    abstract public void Calculate();

    virtual public Block Get_block()
    {
        return _block;
    }
    virtual public void Set_Block(Block block)
    {
        _block = block;
    }
    }