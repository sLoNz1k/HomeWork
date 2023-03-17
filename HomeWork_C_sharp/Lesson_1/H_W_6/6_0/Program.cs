// string s = "15 20 30 40 50";

// string[] subs = s.Split('0');

// foreach (var sub in subs)
// {
//     Console.WriteLine($"Substring: {sub}");
// }

int Check(int number)
{
    int count = 0;
    
    for(int i = 0; i <= number; i ++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if(a > 0) count ++;
    }
    return count;
}
Console.Write("Введите количество чисел: ");
int Convert = int.Parse(Console.ReadLine()!);
int result = Check(Convert);
Console.WriteLine($"Количество чисел больше нуля: {result}");