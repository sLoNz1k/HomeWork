//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
//dis(x1: (Console.ReadLine()!), y1: (Console.ReadLine()!),z1: (Console.ReadLine()!), x2: (Console.ReadLine()!), y2: (Console.ReadLine()!), z2: (Console.ReadLine()!));
 
//dis(double.Parse(Console.WriteLine(x1,y1,z1,x2,y2,z2)));

double dis(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2)), 2);
}
double x1 = double.Parse(Console.ReadLine()!);
double y1 = double.Parse(Console.ReadLine()!);
double z1 = double.Parse(Console.ReadLine()!);
double x2 = double.Parse(Console.ReadLine()!);
double y2 = double.Parse(Console.ReadLine()!);
double z2 = double.Parse(Console.ReadLine()!);
Console.WriteLine(dis(x1, y1, z1, x2, y2, z2));