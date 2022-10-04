
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("=========== Задача №23 ============= ");

Console.Write("Ведите число: ");
int inputNum = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов {inputNum} -> ");
for (int i = 1; i <= inputNum; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
Console.WriteLine();

