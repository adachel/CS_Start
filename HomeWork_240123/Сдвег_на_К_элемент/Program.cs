// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
// на |K| элементов вправо, если K – положительное и влево, если отрицательное

Console.Clear();
Console.Write("Введите количество элементов массива N = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n];
for (int i = 0; i < a.Length; i++)
    a[i] = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"Начальный массив: {string.Join(", ", a)}");

Console.Write("Введите число сдвига элементов массива на K = ");
int k = Convert.ToInt32(Console.ReadLine());
n = a.Length;

if (k > 0)
{
    for (int j = 0; j < k; j++)
    {
        int temp = a[0];
        for (int i = 1; i < n; i++)
        {
            a[i - 1] = a[i];
        }
        a[n - 1] = temp;
    }
}
    
else
{
    int m = k * (-1);    
    for (int j = 0; j < m; j++)
    {
        int temp = a[n-1];
        for (int i = n - 1; i > 0; i--)
        {
            a[i] = a[i - 1];
        }
        a[0] = temp;
    }    
}
    
Console.WriteLine($"Новый массив: [{string.Join(", ", a)}]");





/*
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
int[] arrayResult = new int[n];
for (int i = 0; i < arrayFirst.Length; i++)
{
  arrayFirst[i] = new Random().Next(1, 11); // [1, 10]
}
Console.WriteLine($"[{string.Join(", ", arrayFirst)}]");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
  for (int i = 0; i < k; i++)
      arrayResult[i] = arrayFirst[n - k + i];
  for (int i = 0; i < n - k; i++)
      arrayResult[k + i] = arrayFirst[i];
  Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
}
else
{
  k = (-1) * k;
  for (int i = 0; i < k; i++)
      arrayResult[n - k + i] = arrayFirst[i];
  for (int i = 0; i < n - k; i++)
      arrayResult[i] = arrayFirst[k + i];
  Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
  */