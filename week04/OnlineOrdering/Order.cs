

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5.0;
        }
        else
        {
            total += 35.0;
        }

        return total;

    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }



    public string PackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += $"Product: {product.ProductName()}, ID: {product.GetId()}\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.CustomerName()}\n{_customer.GetAddress().FullAddress()}";
    }
}