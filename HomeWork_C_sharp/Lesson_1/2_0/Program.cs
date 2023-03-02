int num = int.Parse(Console.ReadLine()!);
int TakeNum(int num)
{
    Console.WriteLine(num);
    return (num /10 %10);
}
int result = TakeNum(num);
Console.WriteLine(result);