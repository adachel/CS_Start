// Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Hello, World!");
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100); // [1, 99]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] Transposition(int[,] matrix, int[,] temp)
{
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            temp[i, j] = matrix[i, j];
            matrix[i, j] = matrix[matrix.GetLength(0)-1, j];
            matrix[matrix.GetLength(0)-1, j] = temp[i, j];
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

Console.Clear();
Console.Write("Введите количество строк N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов M = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[,] temp = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Транспонирование по горизонтали:");
Transposition(matrix, temp);
PrintMatrix(matrix);





/*

void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}

void ScreenMatrix(int[,] matrix)
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
  int temp = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    temp = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = temp;
  }
}


Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);

*/