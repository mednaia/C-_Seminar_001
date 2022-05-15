Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
if(a % 2 == 0 && a % 7 == 0)
{
    Console.WriteLine($"{a} кратно 2 и 7.");
}
else
{
    Console.WriteLine($"{a} не кратно 2 и 7.");
}