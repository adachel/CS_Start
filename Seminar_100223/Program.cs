// Задача 63. Факториал
// 1-ой вариант
// string f(int n)
// {
//   if (n == 1)
//     return "1";
//   return f(n - 1) + $", {n}";
// }

// 2-ой вариант
// void rec(int n)
// {
//     if (n == 1)
//         Console.Write("1 ");
//     else if (n > 1)
//     {
//         Console.Write($"{n} ");
//         rec(n - 1);
//     }
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));



// Задача 65. Факториал от m до n
/*
string f(int n, int m)
{
  if (n == m)
    return $"{m}";
  return f(n - 1, m) + $", {n}";
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n, m));
*/





// Задача 67. Сумма цифр в числе
// int f(int n)
// {
//   if (a / 10 == 0 || a < 10 || a % 10 == a)
//     return n;
//   return f(n / 10) + n % 10;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

/*
// Задача 69 Степень числа
int rec(int a, int b)
{
    if (b == 0 && a != 0)
        return 1;
    return rec(a, b - 1) * a;
}
Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a, b));
*/



// Фибоначи
// int f(int n)
// {
//   if (n == 0) 
//     return 0;

//   if (n == 1) 
//     return 1;
//   return f(n - 1) + f(n - 2);
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));



int f(int n)
{
  if (n == 0) 
    return 0;

  return f(n-1)+1;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));