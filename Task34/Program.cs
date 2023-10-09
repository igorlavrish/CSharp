// 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.



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

int CountEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i] % 2 == 0) count++;
        
    }
    return count;
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


int[] array = CreateArrayRndInt(10, 100, 999);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int countEvenElements = CountEvenElements(array);
Console.WriteLine(countEvenElements);