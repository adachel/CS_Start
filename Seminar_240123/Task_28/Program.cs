// Найти факториал числа
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int f = 0;
for (int i = 1; n < 0; i = i * 10)
{
    n = n / i;
    f = f + n;

    Console.Write($" {f} ");
}
*/


// Task 28


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= n; i++)
    count = count * i;

Console.WriteLine(count);