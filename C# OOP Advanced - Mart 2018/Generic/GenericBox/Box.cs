using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    private List<T> value;

    public Box()
    {
        value = new List<T>();
    }

    public void Add(T item) => this.value.Add(item);

    public T this[int index] => this.value[index];

    public void ChangeValue(Box<string> box, int indexOne, int indexTwo)
    {
        var valueOne = box[indexOne];
        var valueTwo = box[indexTwo];
        box[indexOne].Replace(valueOne, valueTwo);

    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in value)
        {
            stringBuilder.AppendLine($"{item.GetType().FullName}: {item}");
        }
        var items = stringBuilder.ToString().Trim();

        return items;
    }
}
