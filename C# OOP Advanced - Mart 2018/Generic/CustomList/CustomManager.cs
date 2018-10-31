using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomManager<T> : ICustom<T>
{
    private List<T> elemetnts;

    public CustomManager()
    {
        this.elemetnts = new List<T>();
    }

    public void Add(T element) => this.elemetnts.Add(element);

    public bool Contains(T element)
    {
        if (elemetnts.Contains(element))
        {
            return true;
        }
        return false;
    }

    public int CountGreatThan(T element)
    {

        int count = 0;
        foreach (var item in elemetnts)
        {
            var compare = Comparer<T>.Default.Compare(item, element);

            if (compare > 0)
            {
                count++;
            }
        }
        return count;
    }

    public IEnumerator GetEnumerator()
    {
        return this.elemetnts.GetEnumerator();
    }

    public T Max()
    {
        return elemetnts.Max();
    }

    public T Min()
    {
        return elemetnts.Min();
    }

    public T this[int index]
    {
        get
        {
            return elemetnts[index];
        }
        set
        {
            this.elemetnts[index] = value;
        }
    }

    public T Remove(int index)
    {
        elemetnts.RemoveAt(index);
        return elemetnts[index];
    }

    public void Swap(int index1, int index2)
    {
        var first = elemetnts[index1];
        var second = elemetnts[index2];
        elemetnts[index1] = second;
        elemetnts[index2] = first;
    }

    public void Sort()
    {
        this.elemetnts.Sort();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var item in elemetnts)
        {
            stringBuilder.AppendLine($"{item}");
        }

        var print = stringBuilder.ToString();
        return print.Trim();
    }
}