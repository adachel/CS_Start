// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 100 < 1)
{
    Console.WriteLine("Третьей цифры нет"); 
    return;
}

for (int i = 10; a >= 1000; i = i * 1)
    a = a / i;

    int b = a % 10;

Console.WriteLine($"{b}"); 
