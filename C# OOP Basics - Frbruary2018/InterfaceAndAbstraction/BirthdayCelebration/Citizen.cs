using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : Data
{
    public Citizen(string name, int age, long id, string date)
        : base(name, date)
    {
        Age = age;
        Id = id;
    }

    public int Age { get; set; }
    public long Id { get; set; }
}