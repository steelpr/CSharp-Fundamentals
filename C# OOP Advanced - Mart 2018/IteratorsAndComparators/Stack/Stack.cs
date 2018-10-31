using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private List<T> elements;

    public Stack()
    {
        this.elements = new List<T>();
    }

    public void Push(T n)
    {
        elements.Add(n);
    }

    public void Pop()
    {
        if (elements.Count == 0)
        {
            Console.WriteLine("No elements");
        }
        else
        {
            elements.RemoveAt(elements.Count - 1);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        yield return elements[0];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        yield return elements;
    }

    public void PrintAll()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int index = elements.Count - 1; index >= 0; index--)
            {
                Console.WriteLine(elements[index]);
            }
        }
    }
}