Console.WriteLine("Введите коорлинаты точки по оси X и нажмите клавишу Enter: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите коорлинаты точки по оси Y и нажмите клавишу Enter: ");
int y = int.Parse(Console.ReadLine());
if(x>0 && y>0)
{
    Console.WriteLine($"Точка с координатами {x},{y} находится в I четверти координатной плоскости.");
}
else
{
    if(x<0 && y>0)
    {
        Console.WriteLine($"Точка с координатами {x},{y} находится во II четверти координатной плоскости.");
    }
    else
    {
        if(x<0 && y<0)
        {
            Console.WriteLine($"Точка с координатами {x},{y} находится во III четверти координатной плоскости.");
        }
        else
        {
            if(x>0 && y<0)
            {
                Console.WriteLine($"Точка с координатами {x},{y} находится во IV четверти координатной плоскости.");
            }
            else
            {
                Console.WriteLine($"Введены некорректные данные. X и Y должны быть строго больше 0.");
            }
        }
    }
}
