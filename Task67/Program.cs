//  67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfDigit(int n)
{
    if (n == 0) return 0;
 
    return n % 10 + SumOfDigit(n / 10);
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(SumOfDigit(number));