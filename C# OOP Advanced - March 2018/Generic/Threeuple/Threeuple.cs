using System;
using System.Collections.Generic;
using System.Text;

public class Threeuple<T, U, V>
{
    private Dictionary<T, Dictionary<U, V>> values;

    public Threeuple(T itemOne, U itemTwo, V itemThree)
    {
        this.ItemOne = itemOne;
        this.ItemTwo = itemTwo;
        this.ItemThree = itemThree;
        values = new Dictionary<T, Dictionary<U, V>>();
    }

    public T ItemOne { get; set; }

    public U ItemTwo { get; set; }

    public V ItemThree { get; set; }

    public void Add(Threeuple<T, U, V> threeuple)
    { 
        values.Add(threeuple.ItemOne, new Dictionary<U, V> ());
        values[threeuple.ItemOne].Add(threeuple.ItemTwo, threeuple.ItemThree);
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();


        string result = string.Empty;
        foreach (var key in values)
        {
            var pairs = new Dictionary<U, V>(key.Value);

            foreach (var value in pairs)
            {
                stringBuilder.AppendLine($"{key.Key} -> {value.Key} -> {value.Value}");
            }


            result = stringBuilder.ToString().Trim();

        }
        return result;
    }
}