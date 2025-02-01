public class Order
{
    private List<Product> _product;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _product = new List<Product>();
    }

    public string GetCustomerName()
    {
        return _customer.GetCustomerName();
    }

    public List<Product> GetProducts()
    {
        return _product;
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public double CostTotal()
    {
        double total = 0;
        int shippingCost = 5;

        foreach (Product item in _product)
        {
            total += item.TotalCost();
        }

        if (_customer.isUsa())
        {
            total += shippingCost;
        }

        return total;
    }

    public string PackingLabel()
    {
        string packing = "\n";
        foreach (Product item in _product)
        {
            packing += $"{item.GetProductID()}, {item.GetProductName()}\n";
        }

        return packing;
    }

    public string ShippingLabel()
    {
        return $"Shipping label: \n" +
                $"Custpmer: {GetCustomerName()}\n" +
                $"Address: {_customer.GetAddress().CompleteAddress()}";
    }
}