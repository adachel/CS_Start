// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > -100  && a < 100) 
{
    Console.WriteLine("Это не трехзначное число"); 
    return;
}

else if (a <= -1000 || a >= 1000) 
{
    Console.WriteLine("Это не трехзначное число"); 
    return;
}

int x = a / 10; 
int y = x % 10; 

Console.WriteLine($"Вторая цифра числа {y}"); 


