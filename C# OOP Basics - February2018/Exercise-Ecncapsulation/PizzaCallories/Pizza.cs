using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Pizza
{
    private string name;

    public Pizza()
    {
        Toppings = new List<Topping>();
    }

    public Pizza(string namePizza) : this()
    {
        Name = namePizza;
    }

    private double ToppingCalories
    {
        get
        {
            if (this.Toppings.Count == 0)
            {
                return 0;
            }
            return Toppings.Select(c => c.Calories).Sum();
        }
    }

    private double DougjCalories
    {
        get
        {
            if (this.Toppings.Count == 0)
            {
                return 0;
            }
            return Toppings.Select(c => c.Calories).Sum();
        }
    }

    private double Colories => Dough.Calories + ToppingCalories;

    public string Name
    {
        get { return name; }
        set
        {
            Validator.ValidPizzaName(value);
            name = value;
        }
    }

    private Dough Dough { get; set; }
    private List<Topping> Toppings { get; set; }

    public void AddTopping(Topping topping)
    {
        Toppings.Add(topping);
        if (Toppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

   public void SetDough(Dough dough)
    {
        if (Dough != null)
        {
            Dough = dough;
        }
    }

    public override string ToString()
    {
        return $"{Name} - {this.Colories:f2} Calories.";
    }
}
