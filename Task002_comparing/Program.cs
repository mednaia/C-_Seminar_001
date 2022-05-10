Console.WriteLine("Введите первое число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите клавишу Enter: ");
int b = int.Parse(Console.ReadLine());
if(a > b)
     Console.WriteLine($"Max: {a}  Min: {b}");
else 
     Console.WriteLine($"Max: {b}  Min: {a}");