// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int f(int n, int m)
{
  if (n == m)
    return m;
  return f(n - 1, m) + n;
}

Console.Clear();
Console.Write("Введите первое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m > n) 
{
    Console.WriteLine("N - должно быть больше M ");
    return;
}    
Console.Write("Сумма от M до N = ");
Console.WriteLine(f(n, m));
