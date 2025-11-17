using System.Runtime.CompilerServices;

class Menu
{
    private int _input;
    private bool _continue = true;
    private int _goalTypeChoice;
    private MyFile _file = new MyFile();


    public Menu()
    {
    }
    public void Display()
    {
        while (_continue == true)
        {
            Console.WriteLine("Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nSelect a choice from the menu:");
            _input = int.Parse(Console.ReadLine());
                if (_input == 1)
                {
                    Console.WriteLine("Creating New Goal");
                    CreateNewGoal();
                }
                else if (_input == 2)
                {
                    Console.WriteLine("Listing Goals");
                    _file.List_Goals();
                }
                else if (_input == 3)
                {
                    Console.WriteLine("Saving Goals");
                    _file.SaveGoals();
                }
                else if (_input == 4)
                {
                    Console.WriteLine("Loading Goals");
                    _file.Load();
                }
                else if (_input == 5)
                {
                    Console.WriteLine("Recording Events");
                    RecordPoints();
                }
                else if (_input == 6)
                {
                    Console.WriteLine("Quitting....");
                    _continue = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry, please try again.");
                }
        }
    }
    private void RecordPoints()
    {
        Console.Clear();
        Console.WriteLine("Choose Goal to record:");
        _file.List_Goals();
        int choice = int.Parse(Console.ReadLine());
        Goal selectedGoal = _file.GetGoal(choice - 1);
        if (selectedGoal.Get_done() == false)
        {
            selectedGoal.Set_totalPoints(selectedGoal.Get_points() + selectedGoal.Get_totalPoints());
            if (selectedGoal.Get_goalType() == "Simple Goal")
            {
                selectedGoal.Set_done(true);
            }
            else if (selectedGoal.Get_goalType() == "Checklist Goal")
            {
                selectedGoal.Set_counter(selectedGoal.Get_counter() + 1);
                if (selectedGoal.Get_counter() == selectedGoal.Get_doneValue())
                {
                    selectedGoal.Set_totalPoints(selectedGoal.Get_bonus() + selectedGoal.Get_totalPoints());
                    selectedGoal.Set_done(true);
                }
            }
        }
        else
        {
            Console.WriteLine("Selected goal is complete!");
        }
    }
    private void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("Please choose goal type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        try
        {
            _goalTypeChoice = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Incorrect input.");
        }
        bool temp_continue = true;
        while (temp_continue == true)
        {
        if (_goalTypeChoice == 1)
        {
            string goalType = "Simple Goal";
            Console.Clear();
            Console.WriteLine("Enter name of goal:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter description of goal:");
            string description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter point value:");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal user_goal = new SimpleGoal(goalType, name, description, points);
            _file.SaveGoal(user_goal);
            temp_continue = false;
        }
        else if (_goalTypeChoice == 2)
        {
            string goalType = "Eternal Goal";
            Console.Clear();
            Console.WriteLine("Enter name of goal:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter description of goal:");
            string description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter point value:");
            int points = int.Parse(Console.ReadLine());
            EternalGoal user_goal = new EternalGoal(goalType, name, description, points);
            _file.SaveGoal(user_goal);
            temp_continue = false;
        }
        else if (_goalTypeChoice == 3)
        {
            string goalType = "Checklist Goal";
            Console.Clear();
            Console.WriteLine("Enter name of goal:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter description of goal:");
            string description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter base point value:");
            int points = int.Parse(Console.ReadLine());
            int counter = 0;
            Console.Clear();
            Console.WriteLine("How many bonus points should be awared: ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("How many times does this task need to be completed:");
            int doneValue = int.Parse(Console.ReadLine());
            ChecklistGoal user_goal = new ChecklistGoal(goalType, name, description, points, counter, bonus, doneValue);
            _file.SaveGoal(user_goal);
            temp_continue = false;
        }
        else
        {
            Console.WriteLine("Invalid Entry");
        }
        Console.Clear();
        }
    }
}