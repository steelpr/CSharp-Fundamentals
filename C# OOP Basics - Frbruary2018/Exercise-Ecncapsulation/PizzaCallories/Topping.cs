using System;
using System.Collections.Generic;
using System.Text;

public class Topping
{
    const double DEFAULT_MULTIPLIER = 2;

    Dictionary<string, double> topping = new Dictionary<string, double>
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9
    };

    private string type;
    private double weight;
  
    private double Multiplier => topping[Type.ToLower()];
    public double Calories => DEFAULT_MULTIPLIER * Weight * Multiplier;

    public Topping(string name, double weight)
    {
        Type = name;
        Weight = weight;
    }

    public string Type
    {
        get { return type; }
        set
        {
            Validator.ValidTopping(value, topping);
            type = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            Validator.ValidToppingWeight(Type, value);
            weight = value;
        }
    }
}