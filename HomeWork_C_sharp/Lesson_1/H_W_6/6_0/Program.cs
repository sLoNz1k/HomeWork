// string s = "15 20 30 40 50";

// string[] subs = s.Split('0');

// foreach (var sub in subs)
// {
//     Console.WriteLine($"Substring: {sub}");
// }

// int Check(int number)
// {
//     int count = 0;

//     for (int i = 1; i <= number; i++)
//     {
//         Console.Write($"Число {i}: ");
//         int a = int.Parse(Console.ReadLine()!);
//         if (a > 0) count++;
//     }
//     return count;
// }
// Console.Write("Введите количество чисел: ");
// int Convert = int.Parse(Console.ReadLine()!);
// int result = Check(Convert);
// Console.WriteLine($"Количество чисел больше нуля: {result}");

// int CountNum()
// {
//     int count = 0;
//     string word;

//     while(true)
//     {
//         Console.Write("Enter any number: ");
//         word = Console.ReadLine()!;

//         if(word == "") return count;
//         else if(int.Parse(word) > 0 ) count += 1;
//     }
// }
// int a = CountNum();
// Console.WriteLine($"Count of positive number = {a}");

int CountNumbers()
{
    int count = 0;
    string number;

    while (true)
    {
        Console.Write("Введите число: ");
        number = Console.ReadLine()!;
        if (number == "") return count;
        else if (int.Parse(number) > 0) count += 1;
    }
}
int EnterNums = CountNumbers();
Console.WriteLine($"Count of positive numbers: {EnterNums}"); 