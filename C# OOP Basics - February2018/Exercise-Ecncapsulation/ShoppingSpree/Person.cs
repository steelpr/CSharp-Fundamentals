using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    private string bags;
    public List<Product> Bag { get; set; }

    public Person()
    {
    }

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Bag = new List<Product>();
    }

    public string Name
    {
        get { return name; }
        set
        {
            Validator.ValidateName(value);
            name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            Validator.ValidateMoney(value);
            money = value;
        }
    }

    public string Bags
    {
        get { return bags; }
        set { bags = value; }
    }

    public string TryByProduct(Product product)
    {
        if (Money < product.Cost)
        {
            return $"{Name} can't afford {product.Name}";
        }

        Money -= product.Cost;
        Bag.Add(product);
        return $"{Name} bought {product.Name}";
    }

    public override string ToString()
    {
        string shop = Bag.Count > 0 ?
                       string.Join(", ", Bag) : "Nothing bought";
        return $"{Name} - {shop}"; 
    }
}