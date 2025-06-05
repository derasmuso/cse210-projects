using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("12 Orem Blvd", "Orem", "UT", "USA");
        Customer customer1 = new Customer("John David", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Journal", 101, 12.99, 2));
        order1.AddProduct(new Product("Pen", 102, 1.50, 5));


        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost():F2}");
        Console.WriteLine();

        Address address2 = new Address("21 Fake Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Mike Felix", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Basketball", 201, 5.75, 3));
        order2.AddProduct(new Product("Apple", 202, 1.99, 10));
        order2.AddProduct(new Product("Cereal", 203, 1.50, 4));

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost():F2}");
    }
}