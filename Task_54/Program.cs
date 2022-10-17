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
    for (int i = 1; i < array.GetLength(1) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - i - 1; j++)
        {
            if (array[line, j] > array[line, j + 1])
            {
                int val = array[line, j];
                array[line, j] = array[line, j + 1];
                array[line, j + 1] = val;
            }
        }
    }

    return array;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.GetLength(0) - 1)) Console.Write(", ");
    }
    Console.WriteLine("]");
}


void SortArray(int[] array)
{
    for (int i = 1; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int val = array[j];
                array[j] = array[j + 1];
                array[j + 1] = val;
            }
        }
    }
    ArrayPrint(array);
}


Console.WriteLine("=========== Задача №54 ============= ");
int[] array = new int[] { 1, 4, 6, 2, 9 };// 96421

int col = new Random().Next(5, 20);
int row = new Random().Next(5, 20);
int[,] array2d = CreateRndArray2D(row, col, 1, 10);
// int[,] array2d = CreateRndArray2D(5, 5, 1, 10);

Console.WriteLine($"Создан двухмерный массив размером: {array2d.GetLength(0)} х {array2d.GetLength(1)}");
PrintArray2D(array2d);

Console.WriteLine("Сортировка строк по убыванию:");
for (int i = 0; i < array2d.GetLength(0); i++)
{
    SortLineNumArray2D(array2d, i);

}
PrintArray2D(array2d);

// SortLineNumArray2D(array2d, 0);


// ArrayPrint(array);
// SortArray(array);