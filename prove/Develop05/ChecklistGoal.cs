class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override int RecordEvent()
    {
        int totalPoints = _points;
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            totalPoints += _bonus;
        }
        return totalPoints;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string checkMark = IsComplete() ? "X" : " ";
        return $"[{checkMark}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentaion()
    {
        return $"Checklist,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}