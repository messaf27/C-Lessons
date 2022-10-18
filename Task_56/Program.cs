/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
        Console.Write($"({i}) ");
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
            if (j < (array.GetLength(1) - 1)) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

int CalcMinSummRow(int[,] array)
{
    int minSumm = 0;
    int minSummRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSumm = 0;
        Console.Write($"[{i}]: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSumm += array[i, j];
            Console.Write($"{array[i, j]}");
            if (j < (array.GetLength(1) - 1)) Console.Write(" + ");
        }
        Console.WriteLine($" = {tempSumm}");

        if ((minSumm > tempSumm) || (minSumm == 0))
        {
            minSumm = tempSumm;
            minSummRow = i;
        }
    }

    return minSummRow;
}

Console.WriteLine("=========== Задача №56 ============= ");
int col = new Random().Next(4, 10);
int row = new Random().Next(5, 20);
int[,] array2d = CreateRndArray2D(row, col, 0, 9);
// int[,] array2d = CreateRndArray2D(5, 4, 0, 9);

Console.WriteLine($"Создан двухмерный массив размером: {array2d.GetLength(0)} х {array2d.GetLength(1)}");
PrintArray2D(array2d);
Console.WriteLine("Считаем минимальную сумму в строке...");
Console.WriteLine($"Минимальная суума в строке №: {CalcMinSummRow(array2d)}");

/*
Terminal:

PS D:\VSCodeProjects\C#-GB\Task_56> dotnet run
=========== Задача №56 ============= 
Создан двухмерный массив размером: 8 х 7
(0) [6, 2, 4, 9, 5, 0, 8]
(1) [5, 5, 5, 7, 8, 1, 0]
(2) [2, 8, 9, 1, 7, 1, 3]
(3) [1, 1, 9, 3, 3, 6, 0]
(4) [6, 3, 7, 7, 0, 0, 6]
(5) [1, 9, 5, 9, 5, 1, 1]
(6) [0, 9, 1, 0, 0, 2, 2]
(7) [3, 8, 9, 9, 8, 5, 0]
Считаем минимальную сумму в строке...
[0]: 6 + 2 + 4 + 9 + 5 + 0 + 8 = 34
[1]: 5 + 5 + 5 + 7 + 8 + 1 + 0 = 31
[2]: 2 + 8 + 9 + 1 + 7 + 1 + 3 = 31
[3]: 1 + 1 + 9 + 3 + 3 + 6 + 0 = 23
[4]: 6 + 3 + 7 + 7 + 0 + 0 + 6 = 29
[5]: 1 + 9 + 5 + 9 + 5 + 1 + 1 = 31
[6]: 0 + 9 + 1 + 0 + 0 + 2 + 2 = 14
[7]: 3 + 8 + 9 + 9 + 8 + 5 + 0 = 42
Минимальная суума в строке №: 6    
PS D:\VSCodeProjects\C#-GB\Task_56> dotnet run
=========== Задача №56 ============= 
Создан двухмерный массив размером: 15 х 5
(0) [7, 1, 3, 1, 8]
(1) [3, 2, 5, 3, 1]
(2) [3, 9, 7, 5, 1]
(3) [7, 6, 3, 8, 4]
(4) [3, 9, 2, 5, 8]
(5) [8, 8, 3, 4, 7]
(6) [4, 7, 7, 0, 2]
(7) [9, 3, 5, 1, 4]
(8) [5, 4, 2, 2, 0]
(9) [3, 9, 7, 5, 6]
(10) [8, 6, 8, 9, 1]
(11) [4, 7, 9, 0, 1]
(12) [2, 9, 3, 3, 8]
(13) [3, 9, 3, 0, 2]
(14) [4, 1, 9, 9, 7]
Считаем минимальную сумму в строке...
[0]: 7 + 1 + 3 + 1 + 8 = 20
[1]: 3 + 2 + 5 + 3 + 1 = 14
[2]: 3 + 9 + 7 + 5 + 1 = 25
[3]: 7 + 6 + 3 + 8 + 4 = 28
[4]: 3 + 9 + 2 + 5 + 8 = 27
[5]: 8 + 8 + 3 + 4 + 7 = 30
[6]: 4 + 7 + 7 + 0 + 2 = 20
[7]: 9 + 3 + 5 + 1 + 4 = 22
[8]: 5 + 4 + 2 + 2 + 0 = 13
[9]: 3 + 9 + 7 + 5 + 6 = 30
[10]: 8 + 6 + 8 + 9 + 1 = 32
[11]: 4 + 7 + 9 + 0 + 1 = 21
[12]: 2 + 9 + 3 + 3 + 8 = 25
[13]: 3 + 9 + 3 + 0 + 2 = 17
[14]: 4 + 1 + 9 + 9 + 7 = 30
Минимальная суума в строке №: 8
*/