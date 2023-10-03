// 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125


void Squares(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($" {count * count * count} ");
        count++;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Squares(number);