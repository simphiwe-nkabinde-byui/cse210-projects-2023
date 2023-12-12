class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentaion()
    {
        return $"Simple,{_shortName},{_description},{_points},{_isComplete}";
    }
}