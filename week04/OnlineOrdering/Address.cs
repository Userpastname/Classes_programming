public class Address
{
    private string _street = "";
    private string _city = "";

    private string _subNational = "";

    private string _country = "";


    public Address()
    {

    }
    public Address(string street, string city, string subNational, string country)
    {
        _street = street;
        _city = city;
        _subNational = subNational;
        _country = country;
    }

    public bool InUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void printAddress()
    {
        Console.WriteLine(_street);
        Console.WriteLine(_subNational + ", " + _city);
        Console.WriteLine(_country);
    }
}