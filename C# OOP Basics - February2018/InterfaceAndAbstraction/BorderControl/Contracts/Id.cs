using System;

public class Id : INumerable
{
    public Id(string id)
    {
        IdNumber = id;
    }

    public string IdNumber { get; set; }

    public void FakeId(Id id, string fake)
    {
        var n = id.IdNumber;
        var lastN = n.Substring(id.IdNumber.Length - fake.Length);
        
        if(lastN == fake)
        {
            Console.WriteLine(id.IdNumber);
        }
    }
}
