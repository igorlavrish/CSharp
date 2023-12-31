﻿// 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void SquaresOfNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("|");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        // if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        // else Console.Write($"{arr[i]}");
        //Console.WriteLine(" |");
        Console.WriteLine();
    }

}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();

SquaresOfNumbers(array2d);
PrintMatrix(array2d);