﻿



Console.WriteLine("Введитеи первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитеи второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM < 1 || numberN < 1)
{
Console.WriteLine("Некорректный ввод!");
return;
}

PrintRangeNaturalNumbers(numberM, numberN);

void PrintRangeNaturalNumbers(int numM, int numN)
{
if (numM < numN)
{
Console.Write($"{numM} ");
PrintRangeNaturalNumbers(numM + 1, numN);
}

else if (numM > numN)
{
Console.Write($"{numM} ");
PrintRangeNaturalNumbers(numM - 1, numN);
}
else Console.Write($"{numM} ");
}