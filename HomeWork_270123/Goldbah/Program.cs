// Требуется написать программу, производящую согласно утверждению Гольдбаха, 
// разложение заданного чётного числа. Из всех пар простых чисел, 
// сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.

int SimpleNumber (int n) 
{
    int a = 0; // Составное число
    int b = 0; // Простое число
    if (n == 2 || n == 3 || n == 5)
        b = n;  
    
    else if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
        a = n;
        
    else
        b = n;

    return b;
}

Console.Clear();
Console.Write("Введите четное число больше <2>: ");
int Number = Convert.ToInt32(Console.ReadLine());
int dif = 0;
int n = 2;

for (int i = 2; i <= Number / 2; i++)
{
    if (SimpleNumber (n) > 0)
    {
        dif = Number - n;
        if (SimpleNumber (dif) > 0)
        {
            Console.WriteLine($"{SimpleNumber (n)} - первое число");
            Console.WriteLine($"{SimpleNumber (dif)} - второе число");
            break;
        } 
    }
    
    n = n + 1;
}













    
