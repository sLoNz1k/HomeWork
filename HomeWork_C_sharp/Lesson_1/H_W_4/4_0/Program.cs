Console.WriteLine("Введите число возводимое в степень: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень:");
int b = int.Parse(Console.ReadLine()!);
int result = a;
for (int i = 1; i < b; i++)
{
    result = a * result;
}
Console.WriteLine(result);