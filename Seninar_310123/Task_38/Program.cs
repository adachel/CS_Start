// Поменять местами элементы массива


void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReplaceElement(int[] array)
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    int temp = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = temp;
  }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный масссив: [{string.Join(", ", array)}]");
ReplaceElement(array);
Console.WriteLine($"Конечный масссив: [{string.Join(", ", array)}]");
