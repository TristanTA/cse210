class Listing : Activity
{
    // Attributes
    List<string> _questions = new List<string> {"What was your last spiritual experience?", "Who do you care the most for?", "Who do you spend most of your time with and why?"};

    // Behaviors
    public Listing() : base("Listing Activity", "A guide in reflecting on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_startMessage);
        string question = GetQuestion();
        Console.WriteLine(question);
        base.Spinner(10);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine(question);
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

    private string GetQuestion()
    {
        Random random = new Random();
        string randomExperience = _questions[random.Next(_questions.Count)];
        return randomExperience;
    }
}