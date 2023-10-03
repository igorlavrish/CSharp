// 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом

// bool Palindrome(int num)
// {
//     if (num >= 10000 && num < 100000)
//     {
//         int a = num / 10000;
//         int b = num % 10000 / 1000;
//         // int c = num % 1000 / 100;
//         int d = num % 100 / 10;
//         int e = num % 10;
//         return a == e && b == d;
//     }
//     else Console.WriteLine("Введено некорректное число");
// }

static bool Palindrome(int number) 
    { 
        string Number = Convert.ToString(number); 
        if (Number.Length != 5) 
        { 
            Console.WriteLine("Число не пятизначное"); 
            return false; 
        }; 
        return Number[0] == Number[4] && Number[1] == Number[3]; 
 
    }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(number);
Console.WriteLine(result ? "да" : "нет");