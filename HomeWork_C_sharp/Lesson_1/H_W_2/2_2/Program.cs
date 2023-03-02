int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetNum(int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool check(int num)
{
    if(num >= 100)
    {
        return true;
    }
    else
    {
        Console.Write("Третьей цифры нет!");
        return false;
    }
}
int num = Prompt("Введите число: ");
if (check(num))
{
    Console.WriteLine(GetNum(num));
}