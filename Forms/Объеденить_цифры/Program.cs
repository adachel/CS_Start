// Объеденить две цифры в одну

Console.Clear();
Console.Write("Ведите два чиасла через пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int a = size[0];
int b = size[1];
int c = int.Parse(a.ToString() + b.ToString());
Console.Write($"Итоговое число: {c}");
