int firstNum = int.Parse(Console.ReadLine()!);
int secondNum = int.Parse(Console.ReadLine()!);
if (firstNum > secondNum)
{
    Console.Write($"{firstNum} больше {secondNum}");
}
else
{
    Console.Write($"{secondNum} больше {firstNum}");
}    