// 11. Напишите программу, которая 
// 1/ выводит случайное трехзначное число
// 2/ и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// Console.WriteLine($"случайное трехзначное число -> {number}");

// int firstDigit = number / 100;
// int thirdDigitDigit = number % 10;

// int numResult = firstDigit * 10 + thirdDigitDigit;
// Console.WriteLine($"{numResult}");

int number = new Random().Next(100, 1000);

int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {deleteSecondDigit}");

int DeleteSecondDigit(int num)
{
    int firstDigit = number / 100;
    int thirdDigitDigit = number % 10;

    int numResult = firstDigit * 10 + thirdDigitDigit;
    return numResult;
}


