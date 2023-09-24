﻿// 9. Напишите программу, которая 
// 1/ выводит случайное число из отрезка [10, 99] 
// 2/ и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка [10, 99] -> {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10;

// if(firstDigit > secondDigit)
// Console.WriteLine($"{firstDigit}");

// else
// Console.WriteLine($"{secondDigit}");


// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // тернарный оператор
// Console.WriteLine($"{maxDigit}");



int maxDigit = MaxDigit(number);
Console.WriteLine($"{maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}