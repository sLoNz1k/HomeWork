int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetNum(int number)
{
    if(number >= 10000 && number <= 99999)
    {
        int div = number / 10000;
        int dif = div % 10;
    }
}
