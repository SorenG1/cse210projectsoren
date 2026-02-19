using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Seron Gomez", address1);

        Address address2 = new Address("45 Calle Mayor", "Madrid", "Madrid", "Spain");
        Customer customer2 = new Customer("Lucia Martinez", address2);

        Product p1 = new Product("Keyboard", "KB100", 49.99m, 1);
        Product p2 = new Product("Mouse", "MS200", 19.99m, 2);
        Product p3 = new Product("Monitor", "MN300", 159.99m, 1);

        Product p4 = new Product("Headphones", "HP400", 79.99m, 1);
        Product p5 = new Product("Webcam", "WC500", 39.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        Order order2 = new Order(customer2);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}