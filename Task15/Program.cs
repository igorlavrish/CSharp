// 15: Напишите программу, которая 
// 1/ принимает на вход цифру, обозначающую день недели, 
// 2/ и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool WeekendOrNot(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <1 || number > 7) Console.WriteLine("Введено некорректное число");
else
{
    bool result = WeekendOrNot(number);
    Console.WriteLine(result ? "да" : "нет");
}