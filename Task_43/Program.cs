/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("=========== Задача №43 ============= ");
double k1 = 0, k2 = 0, b1 = 0, b2 = 0;

Console.Write("Введите B1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите K1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите B2: ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите K2: ");
k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    Console.Write("Прямые ");

    if (b1 == b2)
        Console.WriteLine("совпадают");
    else
        Console.WriteLine("параллельны");
}
else
{
    Console.WriteLine($"Точка пересечения: ({(b2 - b1) / (k1 - k2)} ; {k1 * (b2 - b1) / (k1 - k2) + b1})");
}


