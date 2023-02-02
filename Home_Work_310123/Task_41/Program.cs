// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Вариант 1
void InputArray(int[] array) 
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
}    

Console.Clear();
Console.Write("Введите кол-во элементов M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любые числа: ");
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Введенные числа: [{string.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    count = count +1; 
}

Console.WriteLine($"Количество чисел бельше < 0 >: {count}"); 


// Вариант 2
// Console.Clear();
// Console.WriteLine("Вводите числа, < 0 > - окончание ввода: ");
// int a = 1;
// int count = 0;  

// while (a != 0)
// {
//     a = Convert.ToInt32(Console.ReadLine());
//     if (a > 0)
//         count = count +1; 
// }

// Console.WriteLine($"Количество чисел бельше < 0 >: {count}"); 
