// 12. Напишите программу, которая 
// 1/ будет принимать на вход два числа 
// 2/ и выводить, является ли первое число кратным второму. 
// 3/ Если первое число не кратно второму числу, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remainder(int firstPar, int secondPar);
{
    return firstPar % secondPar;
}

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);

if (remainder == 0)
Console.WriteLine("Кратно");
else 
Console.WriteLine($"Не кратно, остаток {remainder}");