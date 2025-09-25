public class Order
{
    List<Product> _products = new List<Product>();
    Customer _customer;

    public Order()
    {

    }
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int GetTotal()
    {
        int total = 0;
        if (_customer.InUsa() == true)
        {
            total += 5;
            for (int i = 0; i < _products.Count; i++)
            {
                total += _products[i].GetTotal();
            }
        }
        else
        {
            total += 35;
            for (int i = 0; i < _products.Count; i++)
            {
                total += _products[i].GetTotal();
            }
        }

        return total;
    }

    public void GetPackingLabel()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine(_products[i].NameId());
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        _customer.PrintAddress();
    }
}