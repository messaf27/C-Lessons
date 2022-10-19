
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

// функция Аккермана
int CalcAkkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    if ((n != 0) && (m == 0))
    {
        return CalcAkkerman(n - 1, 1);
    }
    
    return CalcAkkerman(n - 1, CalcAkkerman(n, m - 1));
}

Console.WriteLine("=========== Задача №68 ============= ");
int M = 0, N = 0, calcResult = 0;

Console.Write("Введите M: "); M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: "); N = Convert.ToInt32(Console.ReadLine());

calcResult = CalcAkkerman(M, N);
Console.WriteLine($"M = {M}, M = {N} -> A(M, N) = {calcResult}");

/*
Terminal:
PS D:\VSCodeProjects\C#-GB\Task_68> dotnet run
=========== Задача №68 =============
Введите M: 1
Введите N: 2
M = 1, M = 2 -> A(M, N) = 4
PS D:\VSCodeProjects\C#-GB\Task_68> dotnet run
=========== Задача №68 =============
Введите M: 2
Введите N: 3
M = 2, M = 3 -> A(M, N) = 9
PS D:\VSCodeProjects\C#-GB\Task_68> dotnet run
=========== Задача №68 ============= 
Введите M: 3
Введите N: 2
M = 3, M = 2 -> A(M, N) = 29
PS D:\VSCodeProjects\C#-GB\Task_68> 
*/