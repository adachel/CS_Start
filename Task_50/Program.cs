// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
Console.Write("Введите индекс элемента х = ");
int x = (Convert.ToInt32(Console.ReadLine())) - 1;
Console.Write("Введите индекс элемента y = ");
int y = (Convert.ToInt32(Console.ReadLine())) -1;

if (y < 0 || y >= size[1] || x < 0 || x >= size[0])
{
    Console.Write($"Такого элемента нет");
}
else
    Console.Write($"Элемент массива: {matrix[x, y]} ");
