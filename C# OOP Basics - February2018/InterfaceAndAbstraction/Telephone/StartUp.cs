using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        string[] number = Console.ReadLine()
                      .Split(' ');

        string[] url = Console.ReadLine()
                      .Split();

        foreach (var item in number)
        {
            Smartphone call = new Smartphone(item);
            call.ValidPhone(item);
        }

        foreach (var brows in url)
        {
            Smartphone smartphone = new Smartphone(brows);
            smartphone.ValidUrl(brows);
        }
    }
}
