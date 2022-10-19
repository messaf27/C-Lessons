/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("=========== Задача №66 ============= ");

int M = 0, N = 0, summ = 0;

Console.Write("Введите M: ");
M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = M; i < N + 1; i++)
    summ += i;

Console.Write($"M = {M}; N = {N} -> {summ}");


/*
Terminal: 
=========== Задача №66 =============
Введите M: 1
Введите N: 15
M = 1; N = 15 -> 120
 
=========== Задача №66 ============= 
Введите M: 4
Введите N: 8
M = 4; N = 8 -> 30

*/