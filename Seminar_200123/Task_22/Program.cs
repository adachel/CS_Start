// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
double a = 1;

while (i <= x)
{
    a = Math.Pow(i, 2);
    Console.Write($" {a}");
    i = i + 1;
}


/*
Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= x; i++)
    Console.Write($" {Math.Pow(i, 2)}");
*/
