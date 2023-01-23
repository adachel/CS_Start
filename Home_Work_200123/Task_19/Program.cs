// Программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > -10000 && n < 10000)
{
    Console.Write("Это не пятизначное число: ");
    return;
}
      
else if (n <= -100000 || n >= 100000)
{
    Console.Write("Это не пятизначное число: ");
    return; 
}
    
int a = n / 10000;
int b1 = n / 1000, b = b1 % 10;
int x1 = n / 10, x = x1 % 10;
int y = n % 10;

if ( a == y || b == x)
    Console.WriteLine("Да, это число палиндром: "); 

else
    Console.WriteLine("Нет, это число не палиндром: ");



