Console.WriteLine("Введите трехзначное число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
if(a > 99 && a < 1000)
{
    Console.WriteLine(a % 10);
}
else
{
    Console.WriteLine("Это не трехзначное число!");
}