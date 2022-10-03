// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using System;

Console.WriteLine("=========== Задача №21 ============= ");

int[,] pointAddress = new int[2, 3]; // Двумерный массив [строки (точки), столбцы (XYZ)] 
string[] strXYZ = {"X", "Y", "Z"}; 

/* ---------========= Формула ====================-----------------------------
double GetDistanceXYZ(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}
*/
double CalcDistArrayXYZ(int[,] xyzArray)
{
    return Math.Sqrt(
                        Math.Pow((xyzArray[1, 0]-xyzArray[0, 0]), 2) + 
                        Math.Pow((xyzArray[1, 1]-xyzArray[0, 1]), 2) + 
                        Math.Pow((xyzArray[1, 2]-xyzArray[0, 2]), 2)
                    );
}

for (int i = 0; i < pointAddress.GetLength(0); i++)
{
    Console.WriteLine($"Ведите координаты точки №{i+1} -> (x, y, z)");

    for (int j = 0; j < pointAddress.GetLength(1); j++)
    {
        Console.Write($"{strXYZ[j]}: ");
        pointAddress[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

double result = CalcDistArrayXYZ(pointAddress);
Console.WriteLine($"Расстояние между двумя точками ({pointAddress[0,0]}, {pointAddress[0,1]}, {pointAddress[0,2]}) и ({pointAddress[1,0]}, {pointAddress[1,1]}, {pointAddress[1,2]}): {Math.Round(result, 2)}");
