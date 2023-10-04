// 25: Напишите цикл, 
// 1/ который принимает на вход два числа (A и B) 
// 2/ и возводит число A в натуральную степень B.


int PowerOfNumber (int num1, int num2)
{
    int res = num1;
    if (num2 < 0) num2 = num2 * -1;
    
    for (int i = 1; i < num2; i++)
    {
        res = res * num1;
    }
    return res;
}


Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = PowerOfNumber(A, B);
Console.WriteLine($"{A} в степени {B} = {result}");

