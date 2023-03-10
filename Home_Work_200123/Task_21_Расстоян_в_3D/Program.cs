// Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите координаты точки A(x): ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A(y): ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A(z): ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B(x): ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B(y): ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B(z): ");
double z2 = Convert.ToDouble(Console.ReadLine());

double X = Math.Pow(x1 - x2, 2); 
double Y = Math.Pow(y1 - y2, 2); 
double Z = Math.Pow(z1 - z2, 2); 

double S = Math.Sqrt(X + Y + Z);
double L = Math.Round(S, 2);

Console.WriteLine($"Расстояние между A и B: {L}");

/*
// Task 21

Console.Clear();
Console.Write("Введите координату X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Результат: {Math.Round(S, 2)}");
*/





