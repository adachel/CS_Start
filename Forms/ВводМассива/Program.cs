// Массив из случайных целых чисел
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
///////////////////////////////////////////////////////////////////////////////////


// Ввод строковых данных
// Console.WriteLine("Введите имя");
// string? username = Console.ReadLine();
// if (username?.ToLower() == "дмитрий")
// {
//     Console.WriteLine("Приветствую Вас дорогой Дмитрий");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }
////////////////////////////////////////////////////////////////////////////////////////


// Ввод в массив дробных чисел
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
//////////////////////////////////////////////////////////////////////////////////////////////////


// Ввод в консоли пока не введен < 0 >. Не в массив
// while (a != 0)
//     a = Convert.ToInt32(Console.ReadLine());
//////////////////////////////////////////////////////////////////////////////////////////////////


// Ввод текстовых данных и перевод их char
// Console.Clear();
// Console.Write("Введите не более восьми букв и цифр: ");
// string? n = Console.ReadLine();
// int length = Convert.ToInt32(n.Length); // Присваиваем Length длину текста.
// if (length >8)
// {
//     Console.Write("Введите не более ВОСЬМИ букв и цифр!");
//     return;
// }
// char[] c = n.ToCharArray(); // Конвертируем в char
//Console.WriteLine($"Длина: {length}");
//Console.WriteLine($"Начальный массив: [{string.Join("  ", c)}]");
//////////////////////////////////////////////////////////////////////////////////////////////////////


