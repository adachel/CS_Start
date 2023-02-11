// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > -100  && a < 100)
{
    Console.WriteLine("Третьей цифры нет"); 
    return;
}

for (int i = 10; a >= 1000; i = i * 1)
    a = a / i;

int b = a % 10;
    
Console.WriteLine($"Третья цифра числа: {b}"); 

/*
// Код препода
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
    Console.WriteLine("Третьей цифры нет"); 

else
{
    while (a >= 1000)
    {
        a = a / 10;
    }
    Console.WriteLine($"Число: {a}"); 
    Console.WriteLine($"Третья цифра числа: {a % 10}"); 

}
*/




