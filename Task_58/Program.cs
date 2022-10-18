/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateMatrix(int row, int col, int rndMin, int rndMax)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(rndMin, rndMax + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write($"({i}) ");
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
            if (j < (matrix.GetLength(1) - 1)) Console.Write("\t");
        }
        Console.WriteLine("]");
    }
}

void PrintMatrixMultiple(int[,] A, int[,] B)
{
    if (A.GetLength(1) != B.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя умножать!");
    }
    else
    {
        int[,] C = new int[A.GetLength(0), B.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        PrintMatrix(C);
    }
}

Console.WriteLine("=========== Задача №58 ============= ");
int[,] matrixA = CreateMatrix(4, 4, 1, 9);
int[,] matrixB = CreateMatrix(4, 6, 1, 9);

// int[,] matrixA = new int[,] { { 2, 4 }, { 3, 2 } };
// int[,] matrixB = new int[,] { { 3, 4 }, { 3, 3 } };

Console.WriteLine("Матрица А: ");
PrintMatrix(matrixA);

Console.WriteLine("Матрица B: ");
PrintMatrix(matrixB);

Console.WriteLine("Результирующая матрица: ");
PrintMatrixMultiple(matrixA, matrixB);

/*
Terminal:
=========== Задача №58 ============= 
Матрица А: 
[2      4]
[3      2]
Матрица B: 
[3      4]
[3      3]
Результирующая матрица: 
[18     20]
[15     18]
PS D:\VSCodeProjects\C#-GB\Task_58> dotnet run
=========== Задача №58 ============= 
Матрица А: 
[7      4       8       8]
[5      4       7       4]
[5      9       1       6]
[1      4       8       7]
Матрица B:
[8      2       8       9       1       2]
[4      3       8       2       7       3]  
[1      4       8       6       3       3]  
[6      7       4       4       9       9]  
Результирующая матрица:
[128    114     184     151     131     122]
[87     78      144     111     90      79] 
[113    83      144     93      125     94] 
[74     95      132     93      116     101]
PS D:\VSCodeProjects\C#-GB\Task_58> 
*/