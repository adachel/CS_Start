Console.Clear();
Console.WriteLine("Четное ли число?");
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if(b == 0)
{
    Console.WriteLine("Это четное число?");
}
else
Console.WriteLine("Это нечетное число?");

