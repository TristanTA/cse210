class ChecklistGoal : Goal
{
    public ChecklistGoal() {}
    public ChecklistGoal(string goalType, string name, string description, int points, int counter, int bonus, int done) : base(goalType, name, description, points)
    {
        _counter = counter;
        _bonus = bonus;
        _doneValue = done;
    }
}