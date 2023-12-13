using System;

class Program
{
    static void Main(string[] args)
    {
        string[] customerNames = System.IO.File.ReadAllLines("customers.txt");
        string[] productData = System.IO.File.ReadAllLines("products.txt");
        string[] addressData = System.IO.File.ReadAllLines("addresses.txt");

        List<Product> productList = new List<Product>();
        foreach (string line in productData)
        {
            string[] lineArr = line.Split(",");
            Product newProduct = new Product(lineArr[0], lineArr[1], Double.Parse(lineArr[2]), Int32.Parse(lineArr[3]));
            productList.Add(newProduct);
        }

        string[] addressData1 = addressData[0].Split(",");
        Address address1 = new Address(addressData1[0], addressData1[1], addressData1[2], addressData1[3]);
        Customer customer1 = new Customer(customerNames[0], address1);
        List<Product> productList1 = new List<Product>() { productList[0], productList[1] };
        Order order1 = new Order(productList1, customer1);

        string[] addressData2 = addressData[1].Split(",");
        Address address2 = new Address(addressData2[0], addressData2[1], addressData2[2], addressData2[3]);
        Customer customer2 = new Customer(customerNames[1], address2);
        List<Product> productList2 = new List<Product>() { productList[2], productList[3] };
        Order order2 = new Order(productList2, customer2);

        List<Order> orders = new List<Order>() { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("\nOrder:");
            Console.WriteLine("---------------");
            string packingLabel = order.GetPackingLabel();
            string shippingLabel = order.GetShippingLabel();
            double totalPrice = order.GetTotalCost();

            Console.WriteLine($"{packingLabel}");
            Console.WriteLine($"{shippingLabel}\n");
            Console.WriteLine($"Total: {totalPrice}");
        }
    }
}