// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("=========== Задача №27 ============= ");

int GetNumSum(int inputNum)
{
    int OutSum = 0, TempResult;

    TempResult = inputNum;
    while(TempResult > 0)
    {
        OutSum += (TempResult % 10);
        TempResult = TempResult / 10;
        // Console.WriteLine($"OutSum = {OutSum}, TempResult = {TempResult}");
    }

    return OutSum;
}

Console.Write("Введите число: ");
int inNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цыфр в числе {inNumber} = {GetNumSum(inNumber)}");