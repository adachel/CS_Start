// N – количество элементов целочисленного массива (1 ≤ N ≤ 100).
// Массив содержит N натуральных чисел от 1 до 31. Все элементы массива разделены пробелом.
// В первую строку вывести нечетные числа.
// Во вторую строку вывести четные числа.
// В третьей строке нужно вывести «YES», если четных больше в противном случае «NO».

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32); // [1, 31]
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join("  ", array)}]");

int even = 0;
int odd = 0;

Console.Write("Нечетные: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 > 0)
    {
        Console.Write($" {array[i]}");
        odd = odd + 1;
    }
}

Console.WriteLine();

Console.Write("Четные: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($" {array[i]}");
        even = even + 1;
    }
}

Console.WriteLine();

if (even > odd)
    Console.WriteLine($"Yes");
else
    Console.WriteLine($"No");
