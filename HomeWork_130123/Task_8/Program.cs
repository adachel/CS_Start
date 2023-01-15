Console.Clear();
Console.WriteLine("Четные числа до числа N");
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int b = N % 2; // Находим остаток числа
int c = N - b; // Ближайшее меньшее четное
int i = 2;
while (i <= c)
{
    Console.Write($"{i} ");
    i = i + 2;
}