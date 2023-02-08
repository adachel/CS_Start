// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void FillMatrix(int[,] matrix) // Создаем массив
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}
void ScreenMatrix(int[,] matrix) // Выводим массив
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

void ReleaseMatrix(int[,] matrix)
{
  int temp = 0; // Временная переменная
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < i; j++) // Цикл до i
    {
      temp = matrix[i, j]; // Строку в темп
      matrix[i, j] = matrix[j, i]; // Переворачивем строки на столбцы
      matrix[j, i] = temp; // Из темпа в столбец
    }
  }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while (size[0] != size[1]) // Проверка условия квадратного массива
{
    Console.Write("Вы ошиблись!\nВедите размеры массива: ");
    size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);
