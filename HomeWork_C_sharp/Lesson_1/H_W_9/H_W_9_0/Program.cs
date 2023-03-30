int SumNaturalFromTo(int M,int N)
{
    if(M > N) return 0;
    return N + SumNaturalFromTo(M, --N);
}
Console.Write("Введите конечное число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите стартовое число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма чисел от {M} до {N} равна: {SumNaturalFromTo(M, N)}");