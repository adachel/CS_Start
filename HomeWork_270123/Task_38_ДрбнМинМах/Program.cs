// Задайте массив дробных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

void ReleaseArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];     
        }  
        else 
        if (array[i] < min)
        {
            min = array[i];
        }        
    }
    double dif = max - min;
    Console.WriteLine($"Min чисело: {min}");
    Console.WriteLine($"Max чисело: {max}");
    Console.WriteLine($"Разница между Мах и Min: {dif}");
}

Console.Clear();
Console.Write("Введите количество элементов массива N = ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine($"Начальный массив: {string.Join("  ", array)}");
ReleaseArray(array);




/*
void InputArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2); // [1, 10]
    // * (end - begin) + begin
}


string DiffMaxAndMin(double[] array)
{
  double minArray = array[0], maxArray = array[0];
  foreach (double element in array)
  {
    if (element > maxArray)
      maxArray = element;
    if (element < minArray)
      minArray = element;
  }
  return $"{maxArray} - {minArray} = {maxArray - minArray}";
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {DiffMaxAndMin(array)}");
*/