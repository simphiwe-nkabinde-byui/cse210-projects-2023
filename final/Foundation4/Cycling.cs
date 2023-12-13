class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int minutes, float speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override float GetDistance()
    {
        return _lengthInMinutes / GetSpeed() * 60;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}