// 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}


double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] arr)
{
    double result = 0;
    double findMax = FindMax(arr);
    double findMin = FindMin(arr);
    result = findMax - findMin;
    return result;
}

void PrintArray(double[] arr)
{
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    //Console.Write("]");
}

double[] array = CreateArrayRndInt(10, -10, 100);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

// double findMax = FindMax(array);
// Console.WriteLine(findMax);

// double findMin = FindMin(array);
// Console.WriteLine(findMin);

double calcDifferenceBetweenMaxMin = CalcDifferenceBetweenMaxMin(array);
Console.WriteLine(calcDifferenceBetweenMaxMin);