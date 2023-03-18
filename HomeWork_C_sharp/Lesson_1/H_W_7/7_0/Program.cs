double[,] FillMassive(int row, int column, int from, int to)
{
    double[,] mass = new double[column, row];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            mass[i, j] = Math.Round(new Random().NextDouble() * (to - from) + from,2);
        }
    return mass;
}

void PrintArray(double[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }

}
Console.Write("Введмте количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введмте количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное значение ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение ");
int to = int.Parse(Console.ReadLine()!);

double[,] mass = FillMassive(row, column, from, to);
PrintArray(mass);