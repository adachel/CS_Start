// Последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();
Console.WriteLine("Вводите числа, < 0 > - окончание ввода: ");
int a = 1;
int max1 = 0;  
int max2 = 0;

while (a != 0)
{
    a = Convert.ToInt32(Console.ReadLine());
   
    if (a >= max1)
    {
        max2 = max1;
        max1 = a;        
    }
    else if (a >= max2)
        {
            max2 = a;
        }
}

Console.WriteLine($"Второе наибольшее число: {max2}"); 


/*
Console.Clear();
int a = Convert.ToInt32(Console.ReadLine()), max1 = a, max2 = 0;

while (a != 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a > max1)
    {
        max2 = max1;
        max1 = a;        
    }

    else if (a >= max2)
    {
        max2 = a;
    }
}

Console.WriteLine($"Второе наибольшее число: {max2}"); 

*/