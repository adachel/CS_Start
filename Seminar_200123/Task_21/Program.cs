// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// Формула расстояния в координатах L=SQR((x2-x1)квадрат + (y2-y1)квадрат)

Console.Clear();
Console.WriteLine("Введите координаты точки А(x): ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки А(y): ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B(x): ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B(y): ");
double y2 = Convert.ToDouble(Console.ReadLine());

double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double S = Math.Round(L, 2);

Console.WriteLine($"Расстояние: {S} ");

// Квадратный корень тип double Math.Sqrt()

// Степень числа тип double Math.Pow(число, степень)

// Округление числа тип double Math.Round(число, знаков после запятой),
// если не указывать знаков после запятой, то округляет до целого.



