// 5. Напишите программу, которая 
// 1/ на вход принимает одно число (N), 
// 2/ а на выходе показывает все целыечисла в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
if (N > 0)
{
    while (count <= N)
    {
        Console.Write($"{count}, ");
        count++;
    }
}

else
Console.WriteLine("Введено некорректное число");