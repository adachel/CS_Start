// Task 28 произведение всех чисел до "n" влючително - факториал числа

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= n; i++)
    count = count * i;

Console.WriteLine(count);