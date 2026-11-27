using System;
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

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total = total + product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label = label + $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label = label + _customer.GetName() + "\n";
        label = label + _customer.GetAddress().GetFullAddress() + "\n";

        return label;
    }
}
