﻿// 17. Напишите программу, которая 
// 1/ принимает на вход координаты точки (X и Y), 
// 2/ причём X ≠ 0 и Y ≠ 0 
// 3/ и выдаёт номер четверти плоскости, в которой находится эта точка.

int Quater(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quater = Quater(xCoordinate, yCoordinate);

string result = quater > 0 
                ? $"Координаты соответствуют {quater} четверти" 
                : "Введены некорректные данные";

Console.WriteLine(result);
