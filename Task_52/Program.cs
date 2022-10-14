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
        summ += array[i, colNum];
    }

    return Math.Round(summ / array.GetLength(0), 1);
}

int col = new Random().Next(5, 20);
int row = new Random().Next(5, 20);
int[,] array2d = CreateRndArray2D(row, col, 1, 10);

Console.WriteLine($"Создан двухмерный массив размером: {array2d.GetLength(0)} х {array2d.GetLength(1)}");
PrintArray2D(array2d);

for (int column = 0; column < array2d.GetLength(1); column++)
{
    Console.WriteLine($"Среднее арифметическое столбца № {column}: {GetAverageValueColArray(array2d, column)}");
}

/*
Terminal:
=========== Задача №52 ============= 
Создан двухмерный массив размером: 10 х 7
[5, 1, 5, 4, 7, 2, 8]
[7, 2, 10, 8, 5, 5, 7]
[4, 8, 9, 5, 7, 7, 8]
[9, 6, 3, 2, 5, 8, 1]
[7, 7, 10, 8, 1, 7, 3]
[7, 2, 3, 9, 1, 8, 2]
[10, 5, 8, 5, 5, 6, 1]
[9, 9, 9, 7, 9, 3, 9]
[7, 4, 5, 7, 8, 4, 8]
[7, 6, 2, 8, 6, 2, 5]
Среднее арифметическое столбца № 0: 7,2  
Среднее арифметическое столбца № 1: 5    
Среднее арифметическое столбца № 2: 6,4  
Среднее арифметическое столбца № 3: 6,3  
Среднее арифметическое столбца № 4: 5,4  
Среднее арифметическое столбца № 5: 5,2  
Среднее арифметическое столбца № 6: 5,2  
*/