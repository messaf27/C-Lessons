/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

int[] CreateRandomArray(int n, int rndMin, int rndMax)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(rndMin, rndMax + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if(i < (array.Length - 1)) Console.Write(", ");
    }
    Console.WriteLine("]");
}

double GetSumOddIndexArray(int[] array)
{
    double sumResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(((i > 0) && (i % 2) > 0))
        {
            sumResult += array[i];
        }
    }
    return sumResult;
}

Console.WriteLine("=========== Задача №36 ============= ");
Console.Write("Введите количество элементов массива: ");
int[] rndArray = CreateRandomArray(Convert.ToInt32(Console.ReadLine()), -100, 100);
Console.Write("Созданный массив: "); PrintArray(rndArray);
Console.WriteLine($"Сумма чисел нечетных элементов: {GetSumOddIndexArray(rndArray)}");