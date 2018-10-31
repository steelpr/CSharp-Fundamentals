using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Box<T> : IEnumerable
{
    private List<T> value;

    public Box()
    {
        value = new List<T>();
    }


    public void Add(T item) => this.value.Add(item);

    public IEnumerator GetEnumerator()
    {
        return value.GetEnumerator();
    }

    public int Greaters(Box<string> box, string element)
    {
        int count = 0;
        foreach (string item in box)
        {
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }
}
