// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay == 1)
{
    Console.WriteLine($"{weekDay} -> Понедельник");
}

else if (weekDay == 2)
{
    Console.WriteLine($"{weekDay} -> Вторник");
}

else if (weekDay == 3)
{
    Console.WriteLine($"{weekDay} -> Среда");
}

else if (weekDay == 4)
{
    Console.WriteLine($"{weekDay} -> Четверг");
}

else if (weekDay == 5)
{
    Console.WriteLine($"{weekDay} -> Пятница");
}

else if (weekDay == 6)
{
    Console.WriteLine($"{weekDay} -> Суббота");
}

else if (weekDay == 7)
{
    Console.WriteLine($"{weekDay} -> Воскресенье");
}

else 
{
    Console.WriteLine("Неправильно набран номер");
}


