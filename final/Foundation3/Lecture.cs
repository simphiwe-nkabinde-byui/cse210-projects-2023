class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string[] eventDetails) : base(eventDetails)
    {
        _speakerName = eventDetails[6];
        _capacity = Int32.Parse(eventDetails[7]);
    }
    public override string GetFullDetails()
    {
        string eventType = this.GetType().Name;
        string standardDetails = base.GetStandardDetails();
        return $"{eventType} Event\n{standardDetails}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}