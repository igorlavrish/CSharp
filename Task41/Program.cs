// using System;
// // 41: Пользователь вводит с клавиатуры M чисел.
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int NumOfElements(int num)
// {
// Console.WriteLine("Введите количество элементов массива");
// int number = Convert.ToInt32(Console.ReadLine());
// return number;
// }

// int[] Array(int[] num)
// {
//     int[] array = new int[NumOfElements];
//     for (int i = 0; i < NumOfElements - 1; i++)
//     {
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         Array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// int PositiveElements (int[] Array)
// {
//     int i = 0;
//     int sum = 0;
//     while(i < Array.Length)
//     {
//         if(Array[i] > 0)
//         sum += 1;
//         i++;
//     }
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }


// Console.Write("[");
// PrintArray(array);
// Console.WriteLine("]");

// int positiveElements = PositiveElements()


Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void mas(int m)
{
for (int i = 0; i < m; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int kol(int[] Array)
{
int i=0;
int sum = 0;
while (i < Array.Length)
{
if(Array[i]>0)
sum = sum + 1;
i = i + 1;
}
return sum;
}

mas(m);
Console.Write($"Чисел больше нуля: {kol(Array)}");