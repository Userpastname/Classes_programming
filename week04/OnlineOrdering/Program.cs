using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("bob", new Address("street1", "city1", "proviceorstate1", "USA")));

        Order order2 = new Order(new Customer("joe", new Address("street2", "city2", "stateorprovince2", "country")));

        order1.AddProduct(new Product("jellygun", "01dki3", 2, 5));
        order1.AddProduct(new Product("realgun", "01dki4", 450, 3));
        order1.AddProduct(new Product("bubblegun", "o1dki8", 34, 1));

        order2.AddProduct(new Product("nailgun", "03dei3", 45, 3));
        order2.AddProduct(new Product("nails", "03dei4", 3, 11));
        order2.AddProduct(new Product("apron", "03dei8", 39, 1));

        Console.WriteLine("total for order 1: $" + Convert.ToString(order1.GetTotal()));

        Console.WriteLine("");
        order1.GetPackingLabel();
        Console.WriteLine("");
        order1.GetShippingLabel();
        Console.WriteLine("");

        Console.WriteLine("total for order 2: $" + Convert.ToString(order2.GetTotal()));

        Console.WriteLine("");
        order2.GetPackingLabel();
        Console.WriteLine("");
        order2.GetShippingLabel();
        Console.WriteLine("");
    }
}