/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("=========== Задача №47 ============= ");

double[,] CreateRndDoubleArray2D(int row, int col, double rndMin, double rndMax)
{
    double[,] array = new double[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rndMin + new Random().NextDouble() * (rndMax - rndMin), 1);
        }
    }

    return array;
}

void PrintArray2D(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
            if (j < (array.GetLength(1) - 1)) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

double[,] array2d = CreateRndDoubleArray2D(3, 4, -10.0, 10.0);
PrintArray2D(array2d);