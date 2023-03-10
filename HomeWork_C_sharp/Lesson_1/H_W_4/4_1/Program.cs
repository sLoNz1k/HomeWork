Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = 0;
while(num > 0)
{
    int temp = num % 10;
    result = temp + result;
    num = num / 10;

}
Console.Write(result);