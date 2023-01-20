// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите координаты точки по Х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки по Y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
    Console.Write("Точка в I четверти: ");

else if (x < 0 && y > 0)
    Console.Write("Точка в II четверти: "); 

else if (x < 0 && y < 0)
    Console.Write("Точка в III четверти: "); 

else if (x > 0 && y < 0)
    Console.Write("Точка во IV четверти: ");

   

   


