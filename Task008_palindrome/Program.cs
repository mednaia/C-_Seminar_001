Console.WriteLine("Введите пятизначное число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
if(a > 9999 && a < 100000)
{
    int digit1 = a / 10000;
    int digit2 = (a / 1000)%10;
    int digit4 = (a / 10)%10;
    int digit5 = a % 10;
    if(digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine($"Число {a} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число {a} не является палиндромом");
    }
}

else
{
    Console.WriteLine("Это не пятизначное число!");
}