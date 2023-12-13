class Address
{
    private string _streetAddress;
    private string _city;

    public Address(string streetAddress, string city)
    {
        _streetAddress = streetAddress;
        _city = city;
    }
    public string GetAddressText()
    {
        return $"{_streetAddress} {_city}";
    }

}