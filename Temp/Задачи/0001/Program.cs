// Записать два натуральных числа через пробел. Значения чисел не превышают 10^9. 
// Вывести одно целое число — сумму чисел А и В.

Console.Clear();
Console.Write("Введите два числа через пробел: ");
int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int sum = size[0] + size[1];
Console.WriteLine($"Сумма чисел: {sum}");

