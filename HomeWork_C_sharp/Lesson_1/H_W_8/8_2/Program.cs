int InputNum(string Message)
{
    Console.Write(Message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] Create2Darray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] array, int MinValue, int MaxValue)
{
    Random Num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Num.Next(MinValue, MaxValue + 1);
        }
    }
}

string Print2Darray(int[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
            if (j != array.GetLength(1) - 1) result += "\t";
            else result += ";\n";
        }
    }
    return result;
}

bool Check(int Rows1, int Columns2)
{
    if(Rows1 != Columns2) return false;
    else return true;
}

int[,] ArrayResult(int[,] array1, int[,] array2)
{
    int SizeRow1 = array1.GetLength(0);
    int SizeColumn2 = array2.GetLength(1);
    int[,] resultMass = new int[SizeRow1, SizeColumn2];
    Console.WriteLine(SizeColumn2);
    Console.WriteLine(SizeRow1);

    for (int i = 0; i < SizeRow1; i++)// 1.i = 0 2.i=1
    {
        for (int j = 0; j < SizeColumn2; j++) //1.j = 0 
        {
            for (int n = 0; n < array1.GetLength(1); n++)
            {
                resultMass[i,j] += array1[i, n] * array2[n, j];
            }
        }
    }
    return resultMass;

}




int from1 = InputNum("Введите минимальное значение первого массива: ");
int to1 = InputNum("Введите максимальное значение первого массива: ");
int Rows1 = InputNum("Введите количество строк первого массива: ");
int Columns1 = InputNum("Введите количество столбцов первого массива: ");

int from2 = InputNum("Введите минимальное значение первого массива: ");
int to2 = InputNum("Введите максимальное значение второго массива: ");
int Rows2 = InputNum("Введите количество строк второго массива: ");
int Columns2 = InputNum("Введите количество столбцов второго массива: ");

int[,] Array1 = Create2Darray(Rows1, Columns1);
int[,] Array2 = Create2Darray(Rows2, Columns2);


FillArray(Array1, from1, to1);
FillArray(Array2, from2, to2);

string result1 = Print2Darray(Array1);
string result2 = Print2Darray(Array2);

Console.Write(result1);
Console.WriteLine();
Console.Write(result2);
Console.WriteLine();
int[,] Array3 = ArrayResult(Array1,Array2);
string result3 = Print2Darray(Array3);
bool Compare = Check(Rows1, Columns2);
if(Compare == false)
{
    Console.WriteLine("Размерность строк и столбцов не совпадает!");
}
else Console.Write(result3);



// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int column)
// {
//     return new int[rows, column];
// }

// void FillArray(int[,] array, int from, int to)
// {
//     Random Num = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Num.Next(from, to);
//         }
//     }
// }

// string Print2Darray(int[,] array)
// {
//     string result = String.Empty;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i, j];
//             if (j != array.GetLength(1) - 1) result += "\t";
//             else result += "\n";
//         }
//     }
//     return result;
// }

// int[,] ResultMatrix(int[,] array1, int[,] array2)
// {
//     int SizeColumn1 = array1.GetLength(1);
//     int SizeRow1 = array1.GetLength(0);
//     int SizeRow2 = array2.GetLength(0);
//     int SizeColumn2 = array2.GetLength(1);
//     int[,] ResultNum = new int[SizeRow1, SizeColumn2];
//     for (int i = 0; i < SizeRow1; i++)
//     {
//         for (int j = 0; j < SizeColumn2; j++)
//         {
//             for (int n = 0; n < SizeRow2; n++)
//             {
//                 ResultNum[i,j] += array1[i,n] * array2[n,j];        
//             }
//         }
        
//     }
//     return ResultNum;
// }

// int[,] Array = Create2DArray(2, 2);
// FillArray(Array, 2, 8);
// string Print = Print2Darray(Array);
// Console.Write(Print);
// Console.WriteLine();

// int[,] Array1 = Create2DArray(2, 2);
// FillArray(Array1, 2, 6);
// string result = Print2Darray(Array1);
// Console.Write(result);
// Console.WriteLine();

// int[,] ResultArray = ResultMatrix(Array, Array1);
// string PrintResult = Print2Darray(ResultArray);
// Console.Write(PrintResult);
