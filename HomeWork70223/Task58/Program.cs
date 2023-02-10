// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void ReleaseMatrix(int[,] array, int[,] firstMatrix, int[,] secondMatrix)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
        }
    }

}

Console.Clear();
Console.Write("Ведите размер массивов: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Первый массив: ");
int[,] firstMatrix = new int[size[0], size[1]];
FillMatrix(firstMatrix);
ScreenMatrix(firstMatrix);

Console.WriteLine();
Console.WriteLine("Второй массив: ");
int[,] secondMatrix = new int[size[0], size[1]];
FillMatrix(secondMatrix);
ScreenMatrix(secondMatrix);

Console.WriteLine();
Console.WriteLine("Итоговый массив: ");
int[,] array = new int[size[0], size[1]];
ReleaseMatrix(array, firstMatrix, secondMatrix);
ScreenMatrix(array);