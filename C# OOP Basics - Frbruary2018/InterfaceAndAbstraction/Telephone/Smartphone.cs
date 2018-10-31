using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Smartphone : IBrowsable
{
    const string VALID_NUMBER = @"\d+";

    public Smartphone(string model)
    {
        Model = model;
    }

    public string Model { get; set; }
    
    public void ValidPhone(string name)
    {
        if (!Regex.IsMatch(name, VALID_NUMBER))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            Console.WriteLine($"Calling... {name}");
        }
    }

    public void ValidUrl(string name)
    {
        if (Regex.IsMatch(name, VALID_NUMBER))
        {
            Console.WriteLine("Invalid URL!");
        }
        else
        {
            Console.WriteLine($"Browsing: {name}!");
        }
    }
}
