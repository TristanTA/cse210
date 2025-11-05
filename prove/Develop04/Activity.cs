using System.ComponentModel;

public class Activity
{
    // Attributes
    protected int _duration;
    protected string _activity;
    protected string _description;
    protected string _startMessage;
    protected string _endMessage;
    protected string _instructions;

    // Behaviors
    public Activity(string activity, string description)
    {
        Console.WriteLine("Enter Duration (number only):");
        _duration = int.Parse(Console.ReadLine());
        _activity = activity;
        _description = description;
        _startMessage = $"Welcome to {_activity}, {_description}. Prepare to begin.";
        _endMessage = $"Great Job! You have completed {_activity} for {_duration} seconds.";

    }
    public void Spinner(int duration)
    {
        string[] sequence = new[] { "|", "-", "<"};
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(sequence[index]);
            Thread.Sleep(600);
            index = (index + 1) % sequence.Length;
        }
        Console.WriteLine("\n");
    }
}