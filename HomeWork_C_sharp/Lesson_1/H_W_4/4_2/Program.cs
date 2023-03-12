void FillMassive(int[] mass)
{
    for(int i = 0;i<mass.Length;i++)
    {
        mass[i] = new Random().Next(1,15);
        Console.Write($"{mass[i]} ");
    }
}
int[] array = new int[8];
FillMassive(array);

