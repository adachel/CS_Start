// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали.

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

// int[,] Transposition(int[,] matrix, int[,] temp)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp[i, j] = matrix[i, j];
//             matrix[i, j] = matrix[matrix.GetLength(0)-i-1, j];
//             matrix[matrix.GetLength(0)-i-1, j] = temp[i, j];
            
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

Console.Clear();
Console.Write("Введите количество строк N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов M = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[,] temp = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
//Console.WriteLine("Транспонирование по горизонтали:");
//Transposition(matrix, temp);
for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < m; j++)
        {
            temp[i, j] = matrix[i, j];
            matrix[i,j] = matrix[n-i-1,j];
            matrix[n-i-1,j] = temp[i, j];
            Console.WriteLine($" qwer {matrix[i, j]} "); 



        }
    }





