// Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно.

Console.Clear();
Console.Write("Ведите число: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int sum = 0;
for(int i = 1; i <= size[0]; i++)
{
    sum = sum + i;
}

Console.Write($"Сумма чисел: {sum}");
