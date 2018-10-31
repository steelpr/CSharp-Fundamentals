using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> listyIterator;
    private int index;


    public ListyIterator()
    {
        this.listyIterator = new List<T>();
        index = 0;
    }
    public void Create(T elements)
    {
        listyIterator.Add(elements);
    }


    public bool Move()
    {
        if (listyIterator.Count > (index + 1))
        {
            index += 1;
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (listyIterator.Count < 1)
        {
            Console.WriteLine("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(listyIterator[index]);
        }
    }

     public void PrintAll()
    {
        foreach (var item in listyIterator)
        {
            Console.Write(item );
        }
    }

    public bool HasNext()
    {
        if ((index + 1) < listyIterator.Count)
        {
            return true;
        }
        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
          yield return listyIterator[index];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
         yield return listyIterator;
    }
}