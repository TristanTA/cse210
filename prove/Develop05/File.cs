using System.Text.Json;
class MyFile
{
    private List<Goal> _goals = new List<Goal>();

    public MyFile(){}
    public void SaveGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void SaveGoals()
    {
    string json = JsonSerializer.Serialize(_goals, new JsonSerializerOptions 
    {
        WriteIndented = true
    });

    File.WriteAllText("prove.Develop05.data.json", json);
    }
public List<Goal> Load(string filepath = "prove.Develop05.data.json")
{
    try
    {
        if (!File.Exists(filepath))
        {
            File.WriteAllText(filepath, "[]");
            _goals = new List<Goal>();
            return _goals;
        }
        string json = File.ReadAllText(filepath);
        _goals = JsonSerializer.Deserialize<List<Goal>>(json) ?? new List<Goal>();
        return _goals;
    }
    catch
    {
        Console.WriteLine("Data file corrupted. Resetting to new empty file.");
        File.WriteAllText(filepath, "[]");
        _goals = new List<Goal>();
        return _goals;
    }
}

    public void List_Goals()
    {
        int counter = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{counter}. {g.Get_name()} — {g.Get_totalPoints()} points");

            counter += 1;
        }
    }
    public Goal GetGoal(int index)
    {
        Goal goal = _goals[index];
        return goal;
    }
}