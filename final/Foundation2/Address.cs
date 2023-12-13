class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddres, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddres;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.Contains("USA");
    }
    public string GetAddressText()
    {
        return $"{_streetAddress}\n{_city}\n{_stateProvince}\n{_country}";
    }
}