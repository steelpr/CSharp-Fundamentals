using System.Collections.Generic;

public class Citizen : IBuyer

{
    ICollection<string> citizen = new List<string>();

    private string name;

    public Citizen()
    {

    }

    public Citizen(string name)
    {
        this.Name = name;
    }

    public int Food { get; set; }

    public string Name
    {
        get { return name; }
        set
        {
            citizen.Add(value);
            name = value;
        }
    }


    public void BuyFood(string name)
    {
        foreach (var item in citizen)
        {
            if (item == name)
            {
                this.Food += 10;
            }
        }
    }
}
