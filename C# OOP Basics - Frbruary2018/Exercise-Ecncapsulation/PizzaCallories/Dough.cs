using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    const double DEFAULT_MULTIPLIER = 2;

    Dictionary<string, double> validFlourType = new Dictionary<string, double>
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1
    };

    Dictionary<string, double> validBakingTechnique = new Dictionary<string, double>
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1
    };

    private string flourType;
    private string bakingTechnique;
    private double weight;

    private double MultiplierFlour => validFlourType[FlourType.ToLower()];
    private double MultiplierTechnique => validBakingTechnique[BakingTechnique.ToLower()];
    public double Calories => DEFAULT_MULTIPLIER * Weight * MultiplierFlour * MultiplierTechnique;

    public Dough(string type, string technique, double weight)
    {
        FlourType = type;
        BakingTechnique = technique;
        Weight = weight;
    }

    public string FlourType
    {
        get { return flourType; }
        set
        {
            Validator.ValidateDough(value, validFlourType);
            flourType = value;
        }
    }


    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            Validator.ValidateDough(value, validBakingTechnique);
            bakingTechnique = value;
        }
    }


    public double Weight
    {
        get { return weight; }
        set
        {
            Validator.ValidDoughWeight(value);
            weight = value;
        }
    }
}
