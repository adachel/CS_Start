// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам: ");
Console.WriteLine();
for (int j = 0; j < size[1]; j++)
{
    double sum = 0;
    for (int i = 0; i < size[0]; i++)
    {
        sum = sum + matrix[i, j];
    }
    double average = sum / size[0];
    Console.Write($"{Math.Round(average, 2)} \t");
}



