/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateRndArray2D(int row, int col, int rndMin, int rndMax)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(rndMin, rndMax + 1);
        }
    }

    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Console.Write($"({i})[");
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
            if (j < (array.GetLength(1) - 1)) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

int[,] SortLineNumArray2D(int[,] array, int line)
{
    for (int i = array.GetLength(1) - 1; i + 1 > 0; i--)
    {
        Console.WriteLine($"index: {i} = {array[line, i]}");

        if(i > 0)
        {
            if (array[line, i - 1] > array[line, i])
            {
                int temp = array[line, i - 1];
                array[line, i - 1] = array[line, i];
                array[line, i] = temp;
            }
        }
    }

    return array;
}

void SortArray()
{
    int[] array = new int[] {1,4,6,2,9};// 96421

    for (int i = array.Length - 1; i + 1 < 0; i--)
    {
        Console.WriteLine($"[{i}] = {array[i]}");
    }
}


Console.WriteLine("=========== Задача №54 ============= ");
// int col = new Random().Next(5, 20);
// int row = new Random().Next(5, 20);
// // int[,] array2d = CreateRndArray2D(row, col, 1, 10);
// int[,] array2d = CreateRndArray2D(5, 5, 1, 10);

// Console.WriteLine($"Создан двухмерный массив размером: {array2d.GetLength(0)} х {array2d.GetLength(1)}");
// PrintArray2D(array2d);
// Console.WriteLine("Sort:");
// PrintArray2D(SortLineNumArray2D(array2d, 0));

SortArray();