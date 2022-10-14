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
int[,] array2d = CreateRndArray2D(row, col, 10, 99);

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

/*
Terminal:
=========== Задача №50 ============= 
Создан двухмерный массив размером: 5 х 4
[87, 10, 27, 17]
[93, 80, 39, 88]
[87, 31, 74, 63]
[90, 54, 67, 26]
[91, 62, 90, 83]
Введите адрес элемента массива:
Столбец №:1
Строка №:2
Элемент массива: 31

=========== Задача №50 ============= 
Создан двухмерный массив размером: 7 х 8
[85, 10, 25, 84, 81, 55, 60, 97]
[50, 86, 34, 97, 57, 29, 77, 36]
[60, 68, 53, 80, 21, 63, 73, 79]
[93, 92, 87, 58, 74, 56, 87, 96]
[55, 91, 34, 58, 79, 56, 98, 78]
[51, 86, 29, 19, 53, 65, 95, 44]
[88, 68, 73, 39, 51, 64, 15, 14]
Введите адрес элемента массива:
Столбец №:9
Строка №:9
Такого адреса нет!

*/