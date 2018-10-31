using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SorterManager<T>
{
    private List<T> element;

    public SorterManager()
    {
        this.element = new List<T>();
    }

    public void Add(T elemets) => this.element.Add(elemets);

    public void Sort()
    {
        this.element.Sort();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var item in element)
        {
            stringBuilder.AppendLine($"{item}");
        }

        string result = stringBuilder.ToString().Trim();
        return result;
    }
}