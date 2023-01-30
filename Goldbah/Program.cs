// Требуется написать программу, производящую согласно утверждению Гольдбаха, 
// разложение заданного чётного числа. Из всех пар простых чисел, 
// сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.


int SimpleNumber (int n) 
{
    int a = 2;
    int b = 0; // Простое число
    if (n == 2)
        b = n;

    while (a < n) 
    {
        if (n%a == 0)
        {
            Console.WriteLine($"{n%a} - хрень");
            break;
        }
        
        if (n%a != 0)
            {
                b = n;
                Console.WriteLine($"{b} - rty");
            }    

        a = a + 1;

    }
    return b;
}


Console.Clear();
//Console.Write("Введите четное число больше <2>: ");
//int Number = Convert.ToInt32(Console.ReadLine());
//int dif = 0;
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SimpleNumber (n)} - первое число");


/*
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
*/













    
