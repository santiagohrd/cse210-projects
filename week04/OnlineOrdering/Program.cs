using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Product product1 = new Product(1, "Laptop", 800, 1);
        Product product2 = new Product(2, "Smartphone", 500, 2);
        Product product3 = new Product(3, "Headphones", 100, 3);

        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak Street", "Los Angeles", "CA", "USA");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Order 1 Shipping Label:\n{order1.ShippingLabel()}");
        Console.WriteLine($"Order 1 Total Cost: ${order1.CostTotal():F2}");
        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Order 2 Shipping Label:\n{order2.ShippingLabel()}");
        Console.WriteLine($"Order 2 Total Cost: ${order2.CostTotal():F2}");
    }
}