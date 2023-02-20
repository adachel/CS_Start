// Вася и Петя. Искомое число всегда является трехзначным и вторая его цифра всегда равна девяти, 
// а для получения значения последней достаточно отнять от девяти первую.

Console.Clear();
Console.Write("Введите число: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int a = size[0];
int b = 9;
int c = b - a;
int result = int.Parse(a.ToString() + b.ToString() + c.ToString());
Console.Write($"Результат: {result}");

