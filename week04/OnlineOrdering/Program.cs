using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First order
        Address addr1 = new Address("123 Main St", "BYU Pathway", "IL", "USA");
        Customer cust1 = new Customer("Alice", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Widget", "W123", 10.0, 2));
        order1.AddProduct(new Product("Gadget", "G456", 15.5, 1));

        // Second order
        Address addr2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bob", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Thingamajig", "T789", 5.0, 5));
        order2.AddProduct(new Product("Whatsit", "W987", 20.0, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order ord in orders)
        {
            Console.WriteLine(ord.GetPackingLabel());
            Console.WriteLine(ord.GetShippingLabel());
            Console.WriteLine($"Total Price: ${ord.GetTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
