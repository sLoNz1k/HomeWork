Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine()!);
if (firstNum > secondNum)
{
    Console.Write($"{firstNum} больше {secondNum}");
}
else
{
    Console.Write($"{secondNum} больше {firstNum}");
}    