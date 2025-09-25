public class Product
{
    private string _name = "";
    private string _id = "";
    private int _price = 0;
    private int _quantity = 0;

    public Product()
    {

    }

    public Product(string name, string id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int GetTotal()
    {
        int total = _price * _quantity;
        return total;
    }

    public string NameId()
    {
        string nameid = _name + " " + _id;
        return nameid;
    }
}