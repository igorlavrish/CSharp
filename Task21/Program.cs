// 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.


double Distance(int ax, int ay, int bx, int by, int az, int bz)
{
    int cathet1 = ax-bx;
    int cathet2 = ay-by;
    int cathet3 = az-bz;
    double distance = Math.Sqrt((cathet1 * cathet1) + (cathet2 * cathet2) + (cathet3 * cathet3));
    return distance;
}

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, x2, y2, z1, z2);
double dRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(dRound);