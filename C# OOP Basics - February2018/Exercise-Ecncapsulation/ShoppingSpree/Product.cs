using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal money)
    {
        Name = name;
        Cost = money;
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

    public decimal Cost
    {
        get { return cost; }
        set
        {
            Validator.ValidateMoney(value);
            cost = value;
        }
    }
    public override string ToString()
    {
        return Name; 
    }
}
