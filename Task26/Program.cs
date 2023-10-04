// 26: Напишите программу, которая 
// 1/ принимает на вход число и 
// 2/ выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountDigit(int num)
{
    if (num == 0) return 1;
    if (num < 0) num = num * -1;
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}



Console.WriteLine("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigit(number);
Console.WriteLine($"{number} -> {result}");