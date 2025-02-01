public class Product
{
    private int _productID;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(int id, string name, double price, int quantity)
    {
        _productID = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public string GetProductName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double TotalCost()
    {
        return GetPrice() * GetQuantity();
    }
}