﻿// 6: Напишите программу, которая 
// 1/ на вход принимает число 
// 2/ и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
Console.WriteLine("Число четное");
else
Console.WriteLine("Число нечетное");