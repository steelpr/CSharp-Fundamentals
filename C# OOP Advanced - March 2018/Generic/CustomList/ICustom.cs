using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public interface ICustom<T> : IEnumerable
{
    void Add(T element);

    T Remove(int index);

    bool Contains(T element);

    void Swap(int index1, int index2);

    int CountGreatThan(T element);

    void Sort();

    T Max();

    T Min();
}
