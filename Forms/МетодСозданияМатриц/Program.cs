// Вводим с клавиатуры  в двухмерный массив методом
// void InputMatrixFirst(int[,] matrixFirst)
// {
//     for (int i = 0; i < matrixFirst.GetLength(0); i++)
//     {
//         string? input = Convert.ToString(Console.ReadLine())!;
//         for (int j = 0; j < input.Length; j++)
//         {
//             matrixFirst[i, j] = input[j];
//         }
//     }
// }



// Рандомно заполняем матрицу числами.
// int[,] MatrixGenerator(int rows, int columns)
// {
//     Random _rand = new Random();
//     int[,] res = new int[rows, columns];
//     for (int i = 0; i < res.GetLength(0); i++)
//     {
//         for (int j = 0; j < res.GetLength(1); j++)
//         {
//             res[i, j] = _rand.Next(-100, 100);
//         }
//     }
//     return res;
// }



// // Создание двумерного массива Рандомно Методом
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 21); // [1, 20]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// // Console.ReadLine() - это строка. Split() - разделяет строку через пробел, т.к. в скобках пусто.
// // int.Parse(x)) - переводит строку в число. Select(x => int.Parse(x) - каждое значение в число.
// // ToArray() - собирает числа в массив.
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);