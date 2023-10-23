// 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int q = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[q] = matrix[i, j];
            q++;
        }
    }
    return array;
}

void PrintDictionary(int[] array)
{
    int count = 0;
    int currentNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNum) count++;
        else
        {
            Console.WriteLine($"{currentNum} -> {count}");
            currentNum = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{currentNum} -> {count}");
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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

int[] arr = MatrixToArray(array2d);
Array.Sort(arr);
PrintArray(arr);

Console.WriteLine();
PrintDictionary(arr);