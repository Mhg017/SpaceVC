using System;

public class Custom2DArray<T>
{
    private T[,] array;

    public Custom2DArray(int rows, int columns)
    {
        array = new T[rows, columns];
    }

    public T GetElement(int row, int column)
    {
        return array[row, column];
    }

    public void SetElement(int row, int column, T value)
    {
        array[row, column] = value;
    }

    public void PrintAll()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
