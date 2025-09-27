using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double GetTotalCost()
    {
        double sum = 0;
        foreach (Product p in _products)
        {
            sum += p.GetTotalPrice();
        }

        double shipping = _customer.LivesInUSA() ? 5.0 : 35.0;
        return sum + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}

