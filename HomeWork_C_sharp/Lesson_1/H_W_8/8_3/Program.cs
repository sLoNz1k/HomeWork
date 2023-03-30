int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] array, int from, int to)
{
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = num.Next(from, to + 1);
        }
    }
}

string Print2Darray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i,j];
            if(j == array.GetLength(1) - 1) result += ";\n";
            else result += "\t";        }
    }
    return result;
}

int[] MinRC(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int min_num = array[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > array[i, j])
            {
                min_num = array[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    return indexes;
}

int[,] RemoveRC(int[,] arr, int[] m_indexes)
{
    int n = 0;
    int m = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] new_matr = new int[row - 1, column - 1];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (m_indexes[0] != i && m_indexes[1] != j)
            {
                new_matr[n, m] = arr[i, j];
                m += 1;
            }
        }
        m = 0;        
        if (m_indexes[0] != i) m += 1;        
    }
    return new_matr;
}



int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int from = InputNum("Введите начальное число: ");
int to = InputNum("Введите конечное число: ");

int[,] array = Create2DArray(rows, columns);
FillArray(array, from, to);
string result = Print2Darray(array);
Console.Write(result);
int[] massive1D = MinRC(array);
int[,] ResultArray = RemoveRC(array, massive1D);
string RemoveResult = Print2Darray(ResultArray);
Console.Write(RemoveResult);

