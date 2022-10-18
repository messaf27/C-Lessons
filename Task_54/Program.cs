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
            if (j < (array.GetLength(1) - 1))Console.Write("\t");
            // Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

void SortLineNumArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int val = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = val;
                }           
            }
        }
    }
    PrintArray2D(array);
}



Console.WriteLine("=========== Задача №54 ============= ");
int col = new Random().Next(5, 20);
int row = new Random().Next(5, 20);
int[,] array2d = CreateRndArray2D(row, col, -10, 10);

Console.WriteLine($"Создан двухмерный массив размером: {array2d.GetLength(0)} х {array2d.GetLength(1)}");
PrintArray2D(array2d);
Console.WriteLine("Сортировка строк по убыванию:");
SortLineNumArray2D(array2d);

/*
Terminal:

=========== Задача №54 ============= 
Создан двухмерный массив размером: 10 х 7
[-5     6       -2      8       -1      -1      7]  
[10     7       -2      -7      5       4       -5] 
[5      -8      -2      -6      -3      9       -10]
[7      -6      -7      8       -3      -7      -10]
[6      -8      -8      3       -3      2       -9]
[-4     5       -4      -7      -3      -4      -10]
[7      8       4       -3      -6      -4      7]
[-4     -1      8       -3      -2      9       8]
[-10    -5      8       7       5       2       -1]
[10     -9      -9      8       -8      -10     -10]
Сортировка строк по убыванию:
[8      7       6       -1      -1      -2      -5]
[10     7       5       4       -2      -5      -7]
[9      5       -2      -3      -6      -8      -10]
[8      7       -3      -6      -7      -7      -10]
[6      3       2       -3      -8      -8      -9]
[5      -3      -4      -4      -4      -7      -10]
[8      7       7       4       -3      -4      -6]
[9      8       8       -1      -2      -3      -4]
[8      7       5       2       -1      -5      -10]
[10     8       -8      -9      -9      -10     -10]
PS D:\VSCodeProjects\C#-GB\Task_54> dotnet run
=========== Задача №54 =============
Создан двухмерный массив размером: 6 х 16
[-8     -4      -8      10      2       3       9       -5      6       7       -4      -3      1       -7      -4      5]
[3      -10     -3      -9      6       -2      2       0       -1      -10     1       5       9       -6      6       -9]
[8      -1      -1      -5      10      -3      1       -8      3       9       -7      -10     10      7       2       8]
[5      5       8       0       6       -5      -3      1       -3      1       8       -8      3       -8      4       4]
[-9     4       10      -8      -7      8       -9      -3      6       -9      0       4       -8      -4      -10     -6]
[-3     -1      3       8       -4      4       7       -1      4       -3      9       -9      8       5       -4      -7]
Сортировка строк по убыванию:
[10     9       7       6       5       3       2       1       -3      -4      -4      -4      -5      -7      -8      -8]
[9      6       6       5       3       2       1       0       -1      -2      -3      -6      -9      -9      -10     -10]
[10     10      9       8       8       7       3       2       1       -1      -1      -3      -5      -7      -8      -10]
[8      8       6       5       5       4       4       3       1       1       0       -3      -3      -5      -8      -8]
[10     8       6       4       4       0       -3      -4      -6      -7      -8      -8      -9      -9      -9      -10]
[9      8       8       7       5       4       4       3       -1      -1      -3      -3      -4      -4      -7      -9]
PS D:\VSCodeProjects\C#-GB\Task_54>
*/