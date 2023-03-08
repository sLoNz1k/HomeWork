int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}
bool checkout(int num)
{
    if(num >= 100 && num <= 999)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели неверное число!");
        return false;
    }
}
int num = Prompt("Введите число: ");
if(checkout(num))
{
    Console.WriteLine(num /10 % 10);
}