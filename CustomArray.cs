using System;
using System.Collections.Generic;

public class CustomArray<T>
{
    private T[] array;
    private int count;

    public CustomArray(int initialSize = 10)
    {
        array = new T[initialSize];
        count = 0;
    }

    public int Count { get { return count; } }

    public void Add(T item)
    {
        if (count == array.Length)
        {
            Resize(array.Length * 2);
        }
        array[count++] = item;
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(array, item, 0, count);
        if (index < 0) return false;

        count--;
        Array.Copy(array, index + 1, array, index, count - index);
        array[count] = default(T);
        return true;
    }

    public T Search(Func<T, bool> predicate)
    {
        for (int i = 0; i < count; i++)
        {
            if (predicate(array[i]))
            {
                return array[i];
            }
        }
        return default(T);
    }

    public void Resize(int newSize)
    {
        if (newSize < count) throw new ArgumentException("New size must be greater than the number of elements.");
        Array.Resize(ref array, newSize);
    }

    public void PrintAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
