// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива

void FillMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101);
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
    for(int k = 0; k <= matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1]) 
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;   
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);
