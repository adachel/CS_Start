// Выведите одно натуральное число - A^2 без лидирующих нулей.
// Например, для того, чтобы возвести число 125 в квадрат достаточно 
// 12 умножить на 13 и приписать 25, т.е. приписывая к числу 12*13=156 число 25, получаем результат 15625.

Console.Clear();
Console.Write("Ведите число, оканчивающиеся на 5: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int a = size[0] % 10;
int b = size[0] / 10;
int c = 0;
if(b > 0)
{
    c = (b + 1) * b; 
    c = int.Parse(c.ToString() + (a * a).ToString());
}
else c = a * a;

Console.Write($"Квадрат числа: {c}");
