// 10: Напишите программу, 
// 1/ которая принимает на вход трёхзначное число 
// 2/ и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit (int num)
{
    int result = ((num / 10) % 10);
    return result;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999) Console.WriteLine("Введено некорректное число");
else Console.WriteLine(SecondDigit(number));
