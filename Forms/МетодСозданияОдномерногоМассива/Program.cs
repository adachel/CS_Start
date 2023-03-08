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
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");



// Вводим с клавиатуры  в одномерный массив
// int[] array = new int[5];
// for(int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]"); // Join - соединяет элементы массива через "разделитель".


// Ввод одномерного массива в консоли пока не введен < 0 >. Не в массив
// while (a != 0)
//     a = Convert.ToInt32(Console.ReadLine());


// Заполнение массива в 2 строки
// Random rand = new Random(); // Рандомный массив в две строки. это первая строка.
// int[] resSerial = new int[N].Select(r => rand.Next(0, 5)).ToArray(); // Это вторая строка.



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





