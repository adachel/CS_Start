//Программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; n > 0; i++)
{
    sum = sum + n%10;
    n = n / 10;
}

Console.WriteLine($"Cуммa цифр в числе: {sum} ");

