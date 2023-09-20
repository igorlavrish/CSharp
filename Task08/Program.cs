// 8: Напишите программу, которая 
// 1/ на вход принимает число (N), 
// 2/ а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

if (number > 0)
{
while (count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}
}
else
Console.WriteLine("Введено отрицательное число");