// 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

int SumOfOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length;)
    {
        sum = sum + arr[i];
        i = i + 2;
    }
    return sum;
}

void PrintArray(int[] arr)
{
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    //Console.Write("]");
}


int[] array = CreateArrayRndInt(10, -10, 100);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int sumOfOddNumbers = SumOfOddNumbers(array);
Console.WriteLine(sumOfOddNumbers);