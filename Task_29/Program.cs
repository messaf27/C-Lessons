// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
Console.WriteLine("=========== Задача №29 ============= ");
int[] numArray = new int[8];

Console.WriteLine("Введите 8 чисел: ");
for (int i = 0; i < numArray.GetLength(0); i++)
{
    Console.Write($"Число №{i + 1}: ");
    numArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Массив: [");
for (int i = 0; i < numArray.GetLength(0); i++)
{
    Console.Write($"{numArray[i]}");
    if(i < (numArray.GetLength(0) - 1))Console.Write(", ");
}
Console.WriteLine("]");

