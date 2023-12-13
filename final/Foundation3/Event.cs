class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string[] eventDetails)
    {
        _title = eventDetails[0];
        _description = eventDetails[1];
        _date = eventDetails[2];
        _time = eventDetails[3];
        _address = new Address(eventDetails[4], eventDetails[5]) ;
    }
    public string GetStandardDetails()
    {
        string addressText = _address.GetAddressText();
        return $"{_title}\n{_description}\nDate: {_date} @ {_time}\nVenue: {addressText}";
    }
    public virtual string GetFullDetails()
    {
        return "";
    }
    public string GetShortDescription()
    {
        string type = this.GetType().Name;
        return $"{type} Event, {_title}, {_date}";
    }
}