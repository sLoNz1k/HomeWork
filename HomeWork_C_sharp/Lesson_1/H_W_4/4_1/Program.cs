//Type 1


int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int num_1 =int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(num_1));

//Type 2


int SumNum1(int num)
{
    int sum = 0;
    for(int i = num; num != 0; num /= 10)
        sum += num %10;
    return sum;
}
Console.WriteLine("Введите число: ");
int num_12 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum1(num_12));


//Type 3

double DigitSum(int num)
{
    string n = num.ToString();
    int Length = n.Length;
    double sum = 0;
    for(int i = 0; i < Length; i++)
    {
        double m =char.GetNumericValue(n[i]);
        sum += m;
    }
    return sum;
}
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(DigitSum(n));


// void FillMassive(int[] array, int from , int to)
// {
//     int Lenght = array.Length;
//     for(int i = 0;i < Lenght; i++)
//     {
//         array[i] = new Random().Next(from, to);
//         Console.Write($"{array[i]} ");
//     }
// }

// int[] massive = new int[15];
// Console.WriteLine("Введите старт массива");
// int from = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите конец массива");
// int to = int.Parse(Console.ReadLine()!);
// FillMassive(massive, from, to);
