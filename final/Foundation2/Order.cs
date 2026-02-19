using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        decimal shipping = _customer.LivesInUSA() ? 5m : 35m;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += _customer.GetName() + "\n";
        label += _customer.GetAddress().GetFullAddress();
        return label;
    }
}