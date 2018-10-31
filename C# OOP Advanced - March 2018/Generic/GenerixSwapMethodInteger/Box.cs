using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    private List<T> digit;

    public Box()
    {
        digit = new List<T>();
    }

    //private int myVar;

    public T this[int index]
    {
        get { return digit[index]; }
        set { digit[index] = value; }
    }

    public void Add(T item) => digit.Add(item);

    public void ChandeDigit(Box<int> box, int firstIndex, int secondIndex)
    {
        int firstNumber = box[firstIndex];
        int secondNum = box[secondIndex];
        box[firstIndex] = secondNum;
        box[secondIndex] = firstNumber;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var item in digit)
        {
            stringBuilder.AppendLine($"{item.GetType().FullName}: {item}");
        }
        string write = stringBuilder.ToString().Trim();
        return write;
    }
}
