int firstNum = int.Parse(Console.ReadLine()!);
int secondNum = int.Parse(Console.ReadLine()!);
int thirdNum = int.Parse(Console.ReadLine()!);
int max = 0;
if(firstNum > secondNum)
{
    max = firstNum;
}
else
{
    max = secondNum;
}
if(max < thirdNum)
{
    max = thirdNum;
}
Console.Write($"{max}");