int[,] FillArray(int row, int column, int from, int to)
{
    int[,] mass = new int[from, to];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            mass[i, j] = new Random().Next(from, to);
    return mass;
}

void PrintArray(int[,] array)
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

void SelectNumber(int[,] array, int row, int column)
{
    int Row = array.GetLength(0);
    int Column = array.GetLength(1);

    if (row < 0 || row > Row || column < 0 || column > Column)
        Console.WriteLine("Такой позиции нет!");
    else
        Console.WriteLine($"на строке {row} в столбце {column} находится цифра {array[row, column]}");
}

Console.Write("Введмте количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введмте количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное значение ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение ");
int to = int.Parse(Console.ReadLine()!);

Console.Write("Введите искомую строку: ");
int SearchRow = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомый столбец: ");
int SearchColumn = int.Parse(Console.ReadLine()!);

int[,] massive = FillArray(row, column, from, to);
PrintArray(massive);
Console.WriteLine();
SelectNumber(massive, SearchRow, SearchColumn);