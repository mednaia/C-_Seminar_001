Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
int start = - a;
int end = a;
while(start<=end)
{
    Console.WriteLine(start);
    start = start +1;
}