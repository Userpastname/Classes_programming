public class Customer
{

    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUsa()
    {
        return _address.InUsa();
    }

    public string GetName()
    {
        return _name;
    }

    public void PrintAddress()
    {
        _address.printAddress();
    }
}