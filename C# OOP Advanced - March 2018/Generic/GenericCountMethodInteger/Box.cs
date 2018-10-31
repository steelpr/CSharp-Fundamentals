using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Box<T> : IEnumerable
{
    private List<T> item;

    public Box()
    {
        item = new List<T>();
    }

    public IEnumerator GetEnumerator()
    {
        return item.GetEnumerator();
    }

    public void Add(T items) => item.Add(items);

    public int Compare(Box<double> box, double element)
    {
        int n = 0;

        foreach (double item in box)
        {

            if (item.CompareTo(element) > 0)
            {
                n++;
            }
        }
        return n;
    }
}
