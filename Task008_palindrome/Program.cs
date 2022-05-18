Console.WriteLine("Введите пятизначное число и нажмите клавишу Enter: ");
int[] Num = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}\t");
    Num[i] = int.Parse(Console.ReadLine());
}
if(Num[0] == Num[4] && Num[1] == Num[3])
{
    Console.WriteLine("Введенное число - палиндром");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}