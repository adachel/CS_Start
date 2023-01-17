// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
int x = a /100;

if(x < 1 || x >= 10 )
{
   Console.WriteLine($"Это не трехзначное число {a}"); 
}





