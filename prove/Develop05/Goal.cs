using System.Text.Json.Serialization;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "_goalType")]
[JsonDerivedType(typeof(SimpleGoal), "Simple Goal")]
[JsonDerivedType(typeof(EternalGoal), "Eternal Goal")]
[JsonDerivedType(typeof(ChecklistGoal), "Checklist Goal")]
public abstract class Goal
{
    [JsonInclude] public string _goalType;
    [JsonInclude] public string _name;
    [JsonInclude] public string _description;
    [JsonInclude] public int _points;
    [JsonInclude] public int _totalPoints;
    [JsonInclude] public bool _done;
    [JsonInclude] public int _counter;
    [JsonInclude] public int _bonus;
    [JsonInclude] public int _doneValue;

    public Goal() {}   
    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
    }
    virtual public string Get_goalType(){
        return _goalType;
    }    
    virtual public string Get_name(){
        return _name;
    }
    virtual public string Get_description(){
        return _description;
    }
    virtual public int Get_points(){
        return _points;
    }
    virtual public int Get_totalPoints()
    {
        return _totalPoints;
    }
    virtual public bool Get_done(){
        return _done;
    }
    virtual public int Get_bonus(){
        return _bonus;
    }
    virtual public int Get_counter(){
        return _counter;
    }
    virtual public int Get_doneValue(){
        return _doneValue;
    }
    virtual public void Set_totalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    virtual public void Set_done(bool done)
    {
        _done = done;
    }
        virtual public void Set_counter(int counter)
    {
        _counter = counter;
    }    virtual public void Set_bonus(int bonus)
    {
        _bonus = bonus;
    }    virtual public void Set_doneValue(int doneValue)
    {
        _doneValue = doneValue;
    }
}