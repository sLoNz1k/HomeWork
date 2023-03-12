int[] Array(int massive)
{
    int[] mass = new int[massive];
    for (int i = 0; i < massive; i++)
    {
        mass[i] = new Random().Next(1, 10);


    }
    return mass;
}
void PrintMassive(int[] arry)
{
    int Lenght = arry.Length;
    for (int i = 0; i < Lenght; i++)
    {
        Console.Write($"{arry[i]} ");
    }
}

int SumOddNums(int[] array)
{
    int SumNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            SumNum += array[i];
    }
    if (SumNum != 0)
    {
        Console.Write($"Сумма нечетных чисел = {SumNum}");
        return SumNum;
    }
    else
    {
        Console.Write("Нечётных чисел нет!");
        return SumNum;
    }
}
int[] Mass = Array(3);
PrintMassive(Mass);
Console.WriteLine();
SumOddNums(Mass);