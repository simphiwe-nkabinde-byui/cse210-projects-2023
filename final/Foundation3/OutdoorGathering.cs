class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string[] eventDetails) : base(eventDetails)
    {
        _weatherStatement = eventDetails[6];
    }
    public override string GetFullDetails()
    {
        string eventType = this.GetType().Name;
        string standardDetails = base.GetStandardDetails();
        return $"{eventType} Event\n{standardDetails}\nWeather: {_weatherStatement}";
    }
}