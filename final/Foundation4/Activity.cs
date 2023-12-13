abstract class Activity
{
    private string _date;
    protected int _lengthInMinutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _lengthInMinutes = minutes;
    }
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public string GetSummary()
    {
        string type = this.GetType().Name;
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();
        return $"{_date} {type}({_lengthInMinutes} min): Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
    }

}