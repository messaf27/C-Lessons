/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

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

int GetMaxElementArray(int[] array)
{
    int maxIndex = 0;
    // int result = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxIndex])
            maxIndex = i;
    }

    return array[maxIndex];
}

int GetMinElementArray(int[] array)
{
    int minIndex = 0;
    // int result = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minIndex])
            minIndex = i;
    }

    return array[minIndex];
}

Console.WriteLine("=========== Задача №38 ============= ");

Console.Write("Введите количество элементов массива: ");

int[] rndArray = CreateRandomArray(Convert.ToInt32(Console.ReadLine()), 1, 100);
int maxNum = GetMaxElementArray(rndArray);
int minNum = GetMinElementArray(rndArray);

Console.Write("Созданный массив: "); PrintArray(rndArray);
Console.WriteLine($"Максимальный элемент массива: {maxNum}");
Console.WriteLine($"Минимальный элемент массива: {minNum}");
Console.WriteLine($"Разница между элементами: {maxNum - minNum}");


