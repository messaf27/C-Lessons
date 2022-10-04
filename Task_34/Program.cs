/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/

int[] CreateRandomPositiveArray(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
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

int GetEvenArray(int[] array)
{
    int countResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i] % 2) > 0)
            countResult++;
    }

    return countResult;
}

Console.WriteLine("=========== Задача №29 ============= ");
Console.Write("Введите количество положительных элементов массива: ");
int[] posNums = CreateRandomPositiveArray(Convert.ToInt32(Console.ReadLine()));
Console.Write("Созданный массив: "); PrintArray(posNums);
Console.WriteLine($"Количество четных элементов массив: {GetEvenArray(posNums)}");