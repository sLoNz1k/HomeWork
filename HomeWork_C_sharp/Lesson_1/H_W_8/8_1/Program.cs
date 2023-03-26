// int[,] FillArray(int row, int column, int from, int to)
// {
//     int[,] mass = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             mass[i, j] = new Random().Next(from, to);
//         }
//     }
//     return mass;
// }

// void PrintArray(int[,] array)
// {
//     int RowSize = array.GetLength(0);
//     int ColumnSize = array.GetLength(1);

//     for (int i = 0; i < RowSize; i++)
//     {
//         for (int j = 0; j < ColumnSize; j++)
//         {
//             System.Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// bool Comparison(int row, int column)
// {
//     bool result = row == column;
//     return result;
// }

// string  LessRow(int[,] array)
// {
//     if (Comparison(array.GetLength(0), array.GetLength(1))) return $"Массив не прямоугольный!";
//     int RowSize = array.GetLength(0);
//     int ColumnSize = array.GetLength(1);

//     int sum = 0;
//     int temp = 99999;
//     for (int i = 0; i < RowSize; i++)
//     {
//         sum = 0;
//         for (int j = 0; j < ColumnSize; j++)
//             sum = sum + array[i, j];
//              if (temp > sum) temp = sum;
//     }
//     return $"Сумма самой маленькой строки равна {temp}";

// }


// Console.Write("Введмте количество строк: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("Введмте количество столбцов: ");
// int column = int.Parse(Console.ReadLine()!);
// Console.Write("Введите начальное значение: ");
// int from = int.Parse(Console.ReadLine()!);
// Console.Write("Введите конечное значение: ");
// int to = int.Parse(Console.ReadLine()!);

// int[,] massive = FillArray(row, column, from, to);
// PrintArray(massive);
// Console.WriteLine();
// string lol = LessRow(massive);
// Console.WriteLine(lol);

int InputNumb(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] CreateArray(int row, int column)
{
    return new int[row, column];
}

void FillArray(int[,] array, int from, int to)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(from, to + 1);
        }
    }
}

string PrintArray(int[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
            if (j != array.GetLength(1) - 1)
                result += "\t";
            else
                result += "\n";
        }
    }
    return result;
}

int[] MinValue(int[,] array)
{
    int[] mass = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mass[i] += array[i, j];
        }
    }
    return mass;
}

int MinRow(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[min] > array[i]) min = i;
    }
    return min + 1;
}

string Print1DArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
        if (i != array.Length - 1) result += ";\n ";
        else result += ".";
    }
    return $"Сумма строк двумерного массива: \n {result}";
}

int Rows = InputNumb("Введите количество строк: ");
int Columns = InputNumb("Введите количество столбцов: ");
int from = InputNumb("Введите мнимальное число массива: ");
int to = InputNumb("Введите максимальное число массива: ");

int[,] massive = CreateArray(Rows, Columns);
FillArray(massive, from, to);
string result = PrintArray(massive);
Console.WriteLine(result);
int[] SumOfRows = MinValue(massive);
string Printing = Print1DArray(SumOfRows);
Console.WriteLine(Printing);
int Res = MinRow(SumOfRows);
Console.WriteLine($"Номер строки с наименьшей суммой равна: {Res}");