double[] Array(int MassiveSize)
{
    double[] mass = new double[MassiveSize];
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
    Console.WriteLine($"Разница между {max} и {min} равна = {max - min}");
}
double[] size = Array(20);
PrintMassive(size);
Console.WriteLine();
Substraction(size);