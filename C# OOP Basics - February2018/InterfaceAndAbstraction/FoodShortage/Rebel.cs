using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : IBuyer
{
    ICollection<string> rebel = new List<string>();

    private string name;

    public Rebel()
    {

    }

    public Rebel(string name)
    {
        this.Name = name;
    }

    public int Food { get; set; }

    public string Name
    {
        get { return name; }
        set
        {
            rebel.Add(value);
            name = value;
        }
    }


    public void BuyFood(string name)
    {
        foreach (var item in rebel)
        {
            if (item == name)
            {
                this.Food += 5;
            }
        }
    }
}