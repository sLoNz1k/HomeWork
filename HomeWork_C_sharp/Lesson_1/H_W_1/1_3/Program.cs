Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
int b = 1;
while(b <= a)
{
    if(b %2==0)
    {
    Console.Write($"{b} ");
    b ++;

    }
    else 
    b ++;
}
