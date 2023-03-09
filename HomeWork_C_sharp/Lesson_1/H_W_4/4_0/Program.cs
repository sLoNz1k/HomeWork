Console.WriteLine("Введите число возводимое в степень: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень:");
int b = int.Parse(Console.ReadLine()!);
double natural = Math.Pow(a, b);
Console.WriteLine("Введите число: ");
Console.WriteLine(natural);