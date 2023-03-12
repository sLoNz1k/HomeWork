void PrintMassive(int[] mass)
{
    int Size = mass.Length;
    for(int i = 0; i < Size; i++)
    {
        Console.Write($"{mass[i]} ");
    } 
}


int[] Array(int massive)
{
    int[] arr = new int[massive];
    for(int i = 0; i < massive; i++)
    {
        arr[i] = new Random().Next(100, 999);

    }
    return arr;
}

int ValueOddsNums(int[] array)
{
    int count = 0;
    for(int i = 0;i<array.Length;i++)
    {
        if(array[i] % 2 == 0)
            count = count + 1;
    }
    Console.WriteLine($"Количество чётных чисел -> {count}");
    return count;
}
int[] mass = Array(8);
PrintMassive(mass);
Console.WriteLine();
ValueOddsNums(mass);
