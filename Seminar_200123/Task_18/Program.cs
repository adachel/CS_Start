// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a == 1)
Console.WriteLine("Диапзон координат по Х > 0 и Y > 0 ");

else if ( a == 2)
Console.WriteLine("Диапзон координат по Х < 0 и Y > 0 ");

else if ( a == 3)
Console.WriteLine("Диапзон координат по Х < 0 и Y < 0 ");

else if ( a == 4)
Console.WriteLine("Диапзон координат по Х > 0 и Y < 0 ");


/*
Console.Clear();
Console.Write("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 || a > 4)
{
    Console.WriteLine("Вы ошиблись! Ведите номер четверти ");
    a = Convert.ToInt32(Console.ReadLine());
}

if ( a == 1)
Console.WriteLine("Диапзон координат по Х >= 0 и Y >= 0 ");

else if ( a == 2)
Console.WriteLine("Диапзон координат по Х <= 0 и Y >= 0 ");

else if ( a == 3)
Console.WriteLine("Диапзон координат по Х <= 0 и Y <= 0 ");

else if ( a == 4)
Console.WriteLine("Диапзон координат по Х >= 0 и Y <= 0 ");
*/


