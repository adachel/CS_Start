// Ввод числа методом
// int GetValueByUser(string text) // Метод ввода числа с клавиатуры без проверки на валидность.
// {
//     Console.Write(text);
//     return int.Parse(Console.ReadLine()!); // Parse  - преобразует строку в число
// }
// int GetValueByUser(string text) // Метод ввода числа с клавиатуры с проверки на валидность.
// {
//   int value = 0;
//   bool flag = false;
//   do
//   {
//     Console.Write(text);
//     string s = Console.ReadLine()!;
//     flag = int.TryParse(s, out value) && value > 0;
//   } while (!flag);
//   return value;
// }
// int n = GetValueByUser("Введите число N: "); // Ввод числа



// Создание Рандомно Одномерного массива Методом
// int CreateArray(this int size, int min = 0, int max = 10)
//   {
//     return Enumerable.Range(1, size)
//            .Select(item => Random.Shared.Next(min, max))
//            .ToArray();
//   }



// Создание Рандомно Одномерного массива Методом
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");



// Вводим с клавиатуры  в одномерный массив
// int[] array = new int[5];
// for(int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]"); // Join - соединяет элементы массива через "разделитель".


// Ввод одномерного массива в консоли пока не введен < 0 >. Не в массив
// while (a != 0)
//     a = Convert.ToInt32(Console.ReadLine());



// Создание одномерного массива дробных чисел Рандомно.
// void InputArray(double[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2); // [1, 10]
//                                                                         // * (end - begin) + begin
// }
// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

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