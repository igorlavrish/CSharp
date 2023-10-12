// 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.




bool IsExistTriangle(int s1, int s2, int s3)
{
    return s1 < s2 + s3 && s2 < s1 + s3 && s3 < s1 + s2;
}

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());




bool result = IsExistTriangle(A, B, C);
Console.WriteLine(result ? "Треугольник существует" : "Треугольник не существует");
