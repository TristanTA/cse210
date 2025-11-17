class SimpleGoal : Goal
{
    public SimpleGoal() {}
    public SimpleGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _done = false;
    }
}