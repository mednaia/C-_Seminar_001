Console.WriteLine("Введите первое число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите клавишу Enter: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число и нажмите клавишу Enter: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b>max) max = b;
if (c>max) max = c;

Console.WriteLine($"Max: {max}");
