using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (customer in the USA)
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "NB100", 2.50, 4));
        order1.AddProduct(new Product("Pen Pack", "PN200", 3.00, 2));
        order1.AddProduct(new Product("Backpack", "BP300", 25.00, 1));

        // Second order (customer outside the USA)
        Address address2 = new Address("45 Rua das Flores", "Sao Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Maria Oliveira", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HP400", 40.00, 1));
        order2.AddProduct(new Product("Phone Case", "PC500", 12.00, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
