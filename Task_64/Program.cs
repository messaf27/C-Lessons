/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("=========== Задача №64 ============= ");
int N = 0;

Console.Write("Введите N: ");
N = Convert.ToInt32(Console.ReadLine());

int GetNext(int n)
{
    Console.Write($"{n}");
    if(n > 1) Console.Write(", ");

    if(n == 1) return 1;
    
    return GetNext(n  - 1);
}

Console.Write($"{N}->"); GetNext(N);

/*
Terminal:
PS D:\VSCodeProjects\C#-GB\Task_64> dotnet run
=========== Задача №64 ============= 
Введите N: 5
5->5, 4, 3, 2, 1
PS D:\VSCodeProjects\C#-GB\Task_64> dotnet run
=========== Задача №64 ============= 
Введите N: 10
10->10, 9, 8, 7, 6, 5, 4, 3, 2, 1
PS D:\VSCodeProjects\C#-GB\Task_64> 
*/