/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("=========== Задача №43 ============= ");
int k1 = 0, k2 = 0, b1 = 0, b2 = 0;

Console.Write("Введите B1: ");
b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K1: ");
k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B2: ");
b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K2: ");
k2 = Convert.ToInt32(Console.ReadLine());