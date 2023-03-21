int[,] FillArray(int row, int column, int from, int to)
{
    int[,] mass = new int[row, column];

    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                mass[i, j] = new Random().Next(from, to);

            }
        }
        return mass;
    }
}

void PrintArray(int[,] array)
{
    int RowLenght = array.GetLength(0);
    int ColumnLenght = array.GetLength(1);

    for (int i = 0; i < RowLenght; i++)
    {
        for (int j = 0; j < ColumnLenght; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReverseMaxMin(int[,] array)
{
    int RowLenght = array.GetLength(0);
    int ColumnLenght = array.GetLength(1);
    
    for (int i = 0; i < RowLenght; i++)
    {
        for (int j = 0; j < ColumnLenght; j++)
        {
            for (int n = 0; n < ColumnLenght; n++) 
            {
                if(array[i,j] < array[i,n]) continue;
                {
                    (array[i,j], array[i,n]) = (array[i,n], array[i,j]);
                }
            }
        }

    }
}

Console.Write("Введмте количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введмте количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное значение: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение: ");
int to = int.Parse(Console.ReadLine()!);

int[,] massive = FillArray(row, column, from, to);
PrintArray(massive);
Console.WriteLine();
ReverseMaxMin(massive);
PrintArray(massive);