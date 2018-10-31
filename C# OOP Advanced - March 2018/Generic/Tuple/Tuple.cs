using System;
using System.Collections.Generic;
using System.Text;

public class Tuple<T, U>
{
    private Dictionary<T, U> tuple;

    public Tuple(T item1, U item2)
    {
        this.ItemOne = item1;
        this.ItemTwo = item2;
        this.tuple = new Dictionary<T, U>();

    }

    public void Add(Tuple<T , U> tuple)
    {
        this.tuple.Add(tuple.ItemOne, tuple.ItemTwo);
    }

    public T ItemOne { get; set; }

    public U ItemTwo { get; set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var item in tuple)
        {
            stringBuilder.AppendLine($"{item.Key} -> {item.Value}");
        }

        string write = stringBuilder.ToString().Trim();
        return write;
    }
}