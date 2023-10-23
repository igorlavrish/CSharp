// 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

using Internal;

int[,] CreateMatrixRndIntA(int rows, int columns, int min, int max)
{
    int[,] matrixA = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixA;
}

int[,] CreateMatrixRndIntB(int rows, int columns, int min, int max)
{
    int[,] matrixB = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixB;
}


void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{ // Введите свое решение ниже
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            if (matrixA.GetLength(1) < matrixB.GetLength(0) && matrixA.GetLength(1) > matrixB.GetLength(0)) Console.WriteLine($"It is impossible to multiply.");
        }
    }
}

void PrintMatrixA(int[,] matrixA)
{

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        // Console.Write("|");

        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            Console.Write($"{matrixA[i, j],5}");
        }
        // if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        // else Console.Write($"{arr[i]}");
        //Console.WriteLine(" |");
        Console.WriteLine();
    }

}

void PrintMatrixB(int[,] matrixB)
{

    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        // Console.Write("|");

        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            Console.Write($"{matrixB[i, j],5}");
        }
        // if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        // else Console.Write($"{arr[i]}");
        //Console.WriteLine(" |");
        Console.WriteLine();
    }

}

int[,] array2dA = CreateMatrixRndIntA(3, 4, 1, 10);
PrintMatrixA(array2dA);
Console.WriteLine();

int[,] array2dB = CreateMatrixRndIntB(6, 4, 1, 10);
PrintMatrixB(array2dB);
Console.WriteLine();

MultiplyIfPossible




