// Требуется написать программу, производящую согласно утверждению Гольдбаха, 
// разложение заданного чётного числа. Из всех пар простых чисел, 
// сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.

int SimpleNumber (int n) 
{
    int b = 0; // Простое число
    if (n == 2)
        b = n;

    for (int i = 2; i < n; i++)
    {
        if (n%i == 0)
        {
            b = n%i;
            break;
        }
        
        else b = n;  
    }
    return b;
}

Console.Clear();
Console.Write("Введите четное число больше <2>: ");
int Number = Convert.ToInt32(Console.ReadLine());
int dif = 0;

for (int i = 2; i <= Number; i++)
{
    if (SimpleNumber (i) > 0)
    {
        dif = Number - i;
        if (SimpleNumber (dif) > 0)
        {
            Console.WriteLine($"{SimpleNumber (i)} - первое число");
            Console.WriteLine($"{SimpleNumber (dif)} - второе число");
            break;
        } 
    }
}




/*
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
  countDel = 0;
  for (j = 2; j <= i / 2; j++)
  {
    if (i % j == 0)
        countDel++;
  }
  if (countDel == 0)
  {
    m = n - i; // 992 - 73 = 919
    for (k = 2; k <= (m + 1) / 2; k++)
    {
      if (m % k == 0)
        countDel++;
    }
    if (countDel == 0)
    {
      Console.WriteLine($"{i} {m}");
      return;
    }
  }
}
*/












    
