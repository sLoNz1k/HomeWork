int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int weekday)
{
    if(weekday > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool ValidateWeekday(int weekday)
{
    if(weekday > 0 && weekday <= 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int weekday = Prompt("Введите число: ");
if(ValidateWeekday(weekday))
{
    if(IsWeekend(weekday))
    {
        Console.WriteLine("Ура, у меня выходной!");
    }
    else
    {
        Console.WriteLine("Опять работать");
    }
}
else
{
        Console.WriteLine("Вы ввели не день недели!");
}
