// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}

void ReleaseArray(int[] array)
{
    int sum = 0;
    Console.Write("Элементы на нечетных поициях: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 > 0)
        {
            Console.Write($" {array[i]}");
            sum = sum + array[i];     
        }          
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел на нечетных позициях: {sum}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);




/*
void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101); // [1, 100]
}


int SummaOddInArray(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i+=2)
      summa = summa + array[i];
    return summa;
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {SummaOddInArray(array)}");
*/