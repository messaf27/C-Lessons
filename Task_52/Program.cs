/*
    Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("=========== Задача №52 ============= ");

int[,] CreateRndArray2D(int row, int col, int rndMin, int rndMax)
{
    int[,] array = new int[row, col];
    Console.WriteLine($"Col = {col}, Row = {row}");

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

double GetAverageValueColArray(int[,] array, int colNum)
{
    double summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ +=  array[i, colNum];
    }

    return Math.Round(summ / array.GetLength(0), 1);
}

int col = new Random().Next(5, 20);
int row = new Random().Next(5, 20);
int[,] array2d = CreateRndArray2D(col, row, 1, 10);

Console.WriteLine($"Создан двухмерный массив размером: {array2d.GetLength(0)} х {array2d.GetLength(1)}");
PrintArray2D(array2d);

for (int i = 0; i < array2d.GetLength(1); i++)
{
    Console.WriteLine($"Среднее арифметическое столбца № {i}: {GetAverageValueColArray(array2d, i)}");
}
