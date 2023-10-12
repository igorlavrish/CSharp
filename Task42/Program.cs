// 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int DecToBaseNum(int num, int baseNum)
{
    int result = 0;
    int mult = 1;
    while(num > 0)
    {
        result += num % baseNum * mult;
        num /= baseNum;
        mult *=10;
    }
    return result;
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите основание системы счисления: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int decToBaseNum = DecToBaseNum(number, baseNumber);
Console.WriteLine(decToBaseNum);

