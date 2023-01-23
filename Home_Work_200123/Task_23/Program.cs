// Программа, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица кубов: ");

for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i,3)} ");

    
