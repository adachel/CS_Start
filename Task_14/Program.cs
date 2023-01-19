// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите число дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 7 || a < 1)
{
    Console.Write("Это не номер дня недели:");
}
    
else if (a == 6 || a == 7)
{
    Console.Write("Да, это выходной:");
}

else Console.Write("Нет, это не выходной:");
