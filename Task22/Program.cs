﻿// 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void Squares(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($" {count, 3} {count * count, 5} ");
        count++;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Squares(number);