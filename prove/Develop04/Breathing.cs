class Breathing : Activity
{
    // Attributes
    private int _interval;

    // Behaviors
    public Breathing() : base("Breathing Activity", "A guide in relaxing your body through breathing")
    {
        _interval = CalculateInterval();
    }

    public void Display()
    {
        Console.WriteLine(_startMessage);
        base.Spinner(5);
        string[] sequence = new[] { "Breathe in", "Breathe Out" };
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        DateTime intervalTime = DateTime.Now.AddSeconds(_interval);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Breath In...");
            for (int i = 1; i <= _interval; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Breath Out...");
            for (int i = 1; i <= _interval; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
        }

        Console.Clear();
        Console.WriteLine(_endMessage);
    }

    private int CalculateInterval()
    {
        int interval;
        if (base._duration % 6 == 0)
        {
            interval = 6;
        }
        else if (base._duration % 5 == 0)
        {
            interval = 5;
        }
        else
        {
            interval = 6;
        }
        return interval;
    }
}