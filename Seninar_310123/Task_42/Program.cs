// Десятичное переводим в двоичное

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = String.Empty; // Создание пустой строки
while (n > 0)
{
  result = Convert.ToString(n % 2) + result;
  n = n / 2;
}
Console.WriteLine(result);
