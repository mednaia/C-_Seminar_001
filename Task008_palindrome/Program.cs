Console.WriteLine("Введите пятизначное число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
if(a > 9999 && a < 100000)
{
    if(a / 10000 == a % 10 && (a / 1000)%10 == (a / 10)%10)
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