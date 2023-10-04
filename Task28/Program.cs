// 28: Напишите программу, которая
// 1/ принимает на вход число N 
// 2/ и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ProductOfNumbers(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            prod = prod * i;
        }    
    
    }

    return prod;
}


Console.WriteLine("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int productOfNumbers = ProductOfNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {productOfNumbers}");