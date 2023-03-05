
bool test (int num)
{
    if(num >= 10000 && num <= 99999)
        return true;
    else
    {
        Console.WriteLine("Number isnt five-digit");
        return false;
    }
}
void pallindrome(int num)
{   
    bool test_num = test(num);
    if (test_num == true)
    {
        if(num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
            Console.WriteLine($"{num} -> is Pallindrome");
        else
        {
            Console.WriteLine($"{num} -> isnt Pallindrome");
        }
    }
}
pallindrome(int.Parse(Console.ReadLine())!);
