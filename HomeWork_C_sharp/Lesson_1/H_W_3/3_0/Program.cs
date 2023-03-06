//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> дa
//23432 -> д
void num(int n)
{
    int i = 1;
    while(n >= i)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}
num(int.Parse(Console.ReadLine())!);