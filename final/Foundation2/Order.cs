class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double GetTotalCost()
    {
        double total = 0;
        for (int i = 0; i < _products.Count; i++)
        {
            double productTotal = _products[i].GetTotalPrice();
            total += productTotal;
        }
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string labelText = "";
        foreach (Product product in _products)
        {
            string labelInfo = product.GetLabelInfo();
            labelText += $"{labelInfo}\n";
        }
        return labelText;
    }
    public string GetShippingLabel()
    {
        return _customer.GetLabelInfo();
    }
}