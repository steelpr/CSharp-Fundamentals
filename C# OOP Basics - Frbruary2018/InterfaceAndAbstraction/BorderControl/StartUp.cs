using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        string data = string.Empty;

        List<string> id = new List<string>();

        while ((data = Console.ReadLine()) != "End")
        {
            string[] identity = data.Split();

            var ids = identity.Last();
            id.Add(ids);
        }

        string fake = Console.ReadLine();

        foreach (var item in id)
        {
            Id idControl = new Id(item);
            idControl.FakeId(idControl, fake);
        }
    }
}