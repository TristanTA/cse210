class Reflection : Activity
{
    // Attributes
    List<string> _experiences = new List<string> { "helped someone.", "Really connected with someone", "Spent quality time with family or friends" };
    List<string> _questions = new List<string> { "What did you feel?", "Who was there?", "When did this happen?", "What else do you remember?" };

    // Behaviors
    public Reflection() : base("Reflecting Activity", "A guide in relaxing your body through reflecting on your day")
    {
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_startMessage);
        string experience = GetExperience();
        Console.WriteLine($"Think of a time when you {experience}");
        base.Spinner(10);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine($"Think of a time when you {experience}");
            Console.WriteLine(GetQuestion());
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                counter += 1;
            }
        }
        Console.Clear();
        Console.WriteLine($"You entered {counter} responses.");
        Console.WriteLine(_endMessage);
        base.Spinner(10);
    }

    private string GetExperience()
    {
        Random random = new Random();
        string randomExperience = _experiences[random.Next(_experiences.Count)];
        return randomExperience;
    }
    
    private string GetQuestion()
    {
        Random random = new Random();
        string randomExperience = _questions[random.Next(_questions.Count)];
        return randomExperience;
    }
}