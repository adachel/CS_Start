// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// y = (k2*b1 - k1*b2) / (k2 - k1)
double y = Math.Round(((k2 * b1 - k1 * b2) / (k2 - k1)), 2);

// x = (y - b2) / k2
double x = Math.Round(((y - b2) / k2), 2);

Console.WriteLine($"Координа точки пересечения < X > = {x} и < Y > = {y}");




// Console.Clear();
// Console.Write("Введите значения k(1): ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значения b(1): ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значения k(2): ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значения b(2): ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// Console.WriteLine($"Результат: ({x}, {y})");








