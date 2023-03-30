void EvenNums(int M, int N)
{
    if(N < M) return;
        Console.Write($"{M} ");
    EvenNums(M+2, N);

}
Console.WriteLine("Введите стартовое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное число: ");
int N = int.Parse(Console.ReadLine()!);
if (M % 2!=0)
    M = M +1;
    
EvenNums(M,N);