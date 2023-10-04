// 27: Напишите программу, которая 
// 1/ принимает на вход число 
// 2/ и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)
{
    if (num < 0) num = num * -1;
    int sum = 0;
    
    while (num > 0)
    {
        int num1 = num % 10;
        num = num / 10;   
        sum = sum + num1;
        
    }
    return sum;
}

Console.WriteLine("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(number);
Console.WriteLine($"{number} -> {result}");
