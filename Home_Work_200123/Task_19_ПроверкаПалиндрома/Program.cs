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

if ( a == y && b == x)
    Console.WriteLine("Да, это число палиндром: "); 

else
    Console.WriteLine("Нет, это число не палиндром: ");



// Task 19
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
*/
