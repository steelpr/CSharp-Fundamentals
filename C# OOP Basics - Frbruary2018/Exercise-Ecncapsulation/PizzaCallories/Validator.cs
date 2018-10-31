using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Validator
{
    public static void ValidateDough(string type, Dictionary<string, double> technique)
    {
        if (!technique.ContainsKey(type.ToLower()))
        {
            throw new ArgumentException("Invalid type of dough.");
        }
    }

    public static void ValidDoughWeight(double gram)
    {
        const double MIN_WEIGHT = 1;
        const double MAX_WEIGHT = 200;

        if (gram < MIN_WEIGHT || gram > MAX_WEIGHT)
        {
            throw new ArgumentException("Dough weight should be in the range [1..200].");
        }
    }

    public static void ValidTopping(string type, Dictionary<string, double> name)
    {
        if (!name.ContainsKey(type.ToLower()))
        {
            throw new ArgumentException($"Cannot place {type} on top of your pizza.");
        }
    }

    public static void ValidToppingWeight(string type ,double gram)
    {
        const double MIN_WEIGHT = 1;
        const double MAX_WEIGHT = 50;

        if (gram< MIN_WEIGHT || gram>MAX_WEIGHT)
        {
            throw new ArgumentException($"{type} weight should be in the range[1..50].");
        }
    }

    public static void ValidPizzaName(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length > 15)
        {
            throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
        }
    }
}
