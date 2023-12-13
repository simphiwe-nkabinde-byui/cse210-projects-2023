class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
    public string GetLabelInfo()
    {
        string addressText = _address.GetAddressText();
        return $"Shipping to:\n{_name}\n{addressText}";
    }
}