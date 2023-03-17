double[] Array(int MassiveSize)
{
    double[] mass = new double[MassiveSize];
    Random n_new = new Random();
    for (int i = 0; i < MassiveSize; i++)
    {
        mass[i] = new Random().NextDouble();
    }
    return mass;
}


void PrintMassive(double[] array)
{
    int Lenght = array.Length;
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

void Substraction(double[] massive)
{
    double max = massive[0];
    double min = massive[0];
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > max)
            max = massive[i];
        else if (massive[i] < min)
            min = massive[i];

    }
    Console.WriteLine(($"Разница между {max} и {min} равна = {max - min}"));
}
double[] size = Array(20);
PrintMassive(size);
Console.WriteLine();
Substraction(size);
// double[] Array(int size, int from, int to)
// {
//     double[] arr = new double[size];
//     Random n_new = new Random();
//     for (int i = 1; i < size; i++)
//     {
//         arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
//     }
//     return arr;
// }

// void PrintArray(double[] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//         Console.Write($"{array[i]} ");
// }

// void DiffMaxMin(double[] arr)
// {
//     double n_max = arr[0];
//     double n_min = arr[0];

//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (n_max < arr[i])
//             n_max = arr[i];
//         else if (n_min > arr[i])
//             n_min = arr[i];
//     }
//     Console.Write($"Max: {n_max} , Min: {n_min}. ");
//     Console.Write($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min , 2)} ");

// }
// double[] arr_1 = Array(int.Parse(Console.ReadLine()),
//                     int.Parse(Console.ReadLine()),
//                     int.Parse(Console.ReadLine()));
// PrintArray(arr_1);
// DiffMaxMin(arr_1);



