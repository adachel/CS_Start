// Найти все числа от 0 до 1000 где есть 7.

// Console.Clear();
// for (int i = 0; i < 1000; i++)
// {
//     if (i % 10 == 7)
//     {
//         int b = i;
//         Console.Write($"{b} ");
//     }
//     else if ((i / 10) % 10 == 7)
//     {
//         int b = i;
//         Console.Write($"{b} ");
//     }
//     else if ((i / 100) % 10 == 7)
//     {
//         int b = i;
//         Console.Write($"{b} ");
//     }
// }






string f(int n, int m)
{
    if (n == m) 
        return $"{n}";
    else if (m % 10 == n)
    {
        int a = m; 
        Console.Write($"{a} ");
    } 
    else if ((m / 10) % 10 == n)
    {
        int a = m; 
        Console.Write($"{a} ");
    } 
    else if ((m / 100) % 10 == n)
    {
        int a = m; 
        Console.Write($"{a} ");
    }        
    return f(n, m - 1);
}

Console.Clear();
Console.Write("Введите начальное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(f(n, m));

