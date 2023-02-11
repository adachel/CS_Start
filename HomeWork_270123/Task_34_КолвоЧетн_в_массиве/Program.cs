// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 1000]
}

void ReleaseArray(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        if (element%2 == 0)
            sum = sum + 1;        
    }
    Console.WriteLine($"Количество четных чисел: {sum}");
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
    array[i] = new Random().Next(100, 1000); // [100, 999]
}


int CountEvenInArray(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
      if (element % 2 == 0)
        count++; // count = count + 1;
    }
    return count;
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {CountEvenInArray(array)}");
*/