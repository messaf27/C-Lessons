/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateSpiralMatrix(int dimension)
{
    int[,] matrix = new int[dimension, dimension];
    int i = 0, j = 0;
    int counter = 1;

    while (dimension != 0)
    {
        int k = 0;
        do{
            matrix[i, j++] = counter++;
        } while (++k < dimension - 1);

        for (k = 0; k < dimension - 1; k++)
            matrix[i++, j] = counter++;

        for (k = 0; k < dimension - 1; k++)
            matrix[i, j--] = counter++;

        for (k = 0; k < dimension - 1; k++)
            matrix[i--, j] = counter++;

        if (dimension < 2) dimension = 0;
        else dimension = dimension - 2;

        i++; j++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write($"({i}) ");
        // Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
            if (j < (matrix.GetLength(1) - 1)) Console.Write("\t");
        }
        Console.WriteLine();
        // Console.WriteLine("]");
    }
}
Console.WriteLine("=========== Задача №62 ============= ");
// int[,] array = CreateSpiralMatrix(4);
int[,] array = CreateSpiralMatrix(8);
PrintMatrix(array);

/*
Terminal: 
PS D:\VSCodeProjects\C#-GB\Task_62> dotnet run
=========== Задача №62 ============= 
1       2       3       4
12      13      14      5
11      16      15      6
10      9       8       7
=========== Задача №62 ============= 
1       2       3       4       5       6       7       8 
28      29      30      31      32      33      34      9 
27      48      49      50      51      52      35      10
26      47      60      61      62      53      36      11
25      46      59      64      63      54      37      12
24      45      58      57      56      55      38      13
23      44      43      42      41      40      39      14
22      21      20      19      18      17      16      15
PS D:\VSCodeProjects\C#-GB\Task_62> 
*/