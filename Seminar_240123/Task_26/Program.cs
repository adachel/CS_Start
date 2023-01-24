
/* // Нахера мудрить
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 


for (int i = 1; n / i < 0; i=+10)
    {
        int j = 0;
        int a = n / i;
        j = i + 1;
        Console.WriteLine($"Введите число: {a} ");
        Console.WriteLine($"Введите число: {j} ");
    }
*/


// Task 26 // вот гораздо проще

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n = n / 10;
    count++; // count = count + 1
}
Console.WriteLine(count);