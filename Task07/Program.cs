// 7. Напишите программу, которая 
// 1/ принимает на вход
// трёхзначное число и 
// 2/ на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number%10;

if (number < 0) number *=-1;

if (number >= 100&& number <=999)
{
    Console.WriteLine($"Последняя цифра числа: {lastDigit}");
}
else
Console.WriteLine("Введено некорректное число");