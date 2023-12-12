class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        // Console.Clear();
        Console.WriteLine($"\nYou have {_score} points.\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string goalName = goal.GetGoalName();
            Console.WriteLine($"{i + 1}. {goalName}");
        }
        Console.WriteLine();
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string goalDetials = goal.GetDetailsString();
            Console.WriteLine($"{i + 1}. {goalDetials}");
        }
        Console.WriteLine();
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        List<string> goalDetails = GetGoalDetails();
        string name = goalDetails[0];
        string description = goalDetails[1];
        int points = Int32.Parse(goalDetails[2]);
        switch (goalType)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = Int32.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = Int32.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                break;
            default:
                return;
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = Int32.Parse(Console.ReadLine()) - 1;
        int newPoints = _goals[goalIndex].RecordEvent();
        _goals[goalIndex].ShowCelebrationAnimation();
        Console.WriteLine($"You have earned {newPoints} points");
        _score += newPoints;
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string stringRepresentation = goal.GetStringRepresentaion();
                outputFile.WriteLine($"{stringRepresentation}");
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = Int32.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalAttr = lines[i].Split(",");
            string goalType = goalAttr[0];
            string name = goalAttr[1];
            string description = goalAttr[2];
            int points = Int32.Parse(goalAttr[3]);

            switch (goalType)
            {
                case "Simple":
                    bool complete = goalAttr[4] == "False" ? false : true;
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, complete);
                    _goals.Add(simpleGoal);
                    break;
                case "Eternal":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case "Checklist":
                    int target = Int32.Parse(goalAttr[4]);
                    int bonus = Int32.Parse(goalAttr[5]);
                    int amountCompleted = Int32.Parse(goalAttr[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }
    private List<string> GetGoalDetails()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Whai is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        return new List<string>() { name, description, points };
    }
}