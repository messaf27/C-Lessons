/*
    Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет
*/
Console.WriteLine("=========== Задача №50 ============= ");

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

int col = new Random().Next(1, 10);
int row = new Random().Next(1, 10);
int[,] array2d = CreateRndArray2D(col, row, 10, 99);

// int[,] array2d = new int [,] { { 0, 1, 2 }, { 3, 4, 5 } };

Console.WriteLine($"Создан двухмерный массив размером: {array2d.GetLength(0)} х {array2d.GetLength(1)}");
PrintArray2D(array2d);

Console.WriteLine("Введите адрес элемента массива:");
Console.Write("Столбец №:");
int indexCol = Convert.ToInt32(Console.ReadLine());
Console.Write("Строка №:");
int indexRow = Convert.ToInt32(Console.ReadLine());

if (
    (indexRow < array2d.GetLength(0))
    &&
    (indexCol < array2d.GetLength(1))
)
{
    Console.WriteLine($"Элемент массива: {array2d[indexRow, indexCol]}");
}
else
{
    Console.WriteLine("Такого адреса нет!");
}