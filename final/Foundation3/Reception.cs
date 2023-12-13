class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string[] eventDetails) : base(eventDetails)
    {
        _rsvpEmail = eventDetails[6];
    }
    public override string GetFullDetails()
    {
        string eventType = this.GetType().Name;
        string standardDetails = base.GetStandardDetails();
        return $"{eventType} Event\n{standardDetails}\nRSVP: {_rsvpEmail}";
    }
}