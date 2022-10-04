// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("=========== Задача №25 ============= ");

int numInput = 0, expNum = 0; double result = 1;
Console.Write("Ведите число: "); numInput = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите степень: "); expNum = Convert.ToInt32(Console.ReadLine());

while(expNum > 0)
{   
    result = numInput * result;
    expNum--;
}
Console.WriteLine($"Результат: {result}");