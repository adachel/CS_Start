// По целочисленным координатам вершин треугольника 
// (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
// Входные данные содержат 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. 
// Все числа не превышают 1000000 по абсолютной величине.
// S = p * (p − a) * (p − b) * (p − c), где a, b , c — стороны, 
// p — полупериметр, который можно найти по формуле: p = (a + b + c) / 2
// Формула расстояния в координатах L=SQR((x2-x1)квадрат + (y2-y1)квадрат)

Console.Clear();
Console.Write("Введите координаты точки x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double a = Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))), 2);
double b = Math.Round((Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2))), 2);
double c = Math.Round((Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2))), 2);

if (a + b > c && b + c > a && a + c > b)
  Console.WriteLine($"Стороны треугольника: x = {a}, y = {b}, z = {c} ");
else
{
    Console.WriteLine("Такого треугольника быть не может, введите другие координаты");
    return;
}
  
double p = (a + b + c) / 2;
double s = Math.Sqrt(Math.Round((p * (p - a)*(p - b) * (p - c)), 2));

Console.WriteLine($"Площадь треугольника: {s} ");