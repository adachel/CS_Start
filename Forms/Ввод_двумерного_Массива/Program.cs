// Создание двумерного массива

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
// Console.ReadLine() - это строка. Split() - разделяет строку через пробел, т.к. в скобках пусто.
// int.Parse(x)) - переводит строку в число. Select(x => int.Parse(x) - каждое значение в число.
// ToArray() - собирает числа в массив.
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);