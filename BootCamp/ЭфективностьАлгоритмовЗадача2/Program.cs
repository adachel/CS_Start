// Есть массив n - чисел. Найти сумму всевозможных m - элементов.

// Не эффективное решение, т.к. суммирует все элементы каждый раз
// int[] GetRangeSum1(int[] array, int m) // array - массив, m - подмассив
// {
//     // Кол-во m - сумм = (n - m + 1)
//     int n = array.Length; // Кол-во элементов в исходном массиве
//     int[] t = new int[n - m + 1]; // Суммы элементов
//     int index = 0;
//     for (int i = 0; i <= n - m; i++)
//     {
//         for (int j = i; j < i + m; j++)
//         {
//             t[index] += array[j];
//         }
//         index++;
//     }
//     return t;
// }
// int[] CreateArray(int size) => new int[size];
// {
//     return new int[size]; // Эту запись можно сделать => new int[size];
// }
// string Print(int[] array) => $"[{String.Join(", ", array)}]"; // Вывод массива
// void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray(); // Заполняем массив
// int[] numbers = CreateArray(15); // Создаем методом CreateArray: 15 элементов
// Fill(ref numbers); // Заполняем. ref -  изменяемый
// Console.WriteLine(Print(numbers)); // Выводим основной массив
// int count = 3; // Число элементов в искомой сумме
// int[] sumGroupNumbers = GetRangeSum1(numbers, count); // Запускаем метод поиска сумм
// Console.WriteLine(Print(sumGroupNumbers)); // Выводим массив с суммами

///////////////////////////////////////////////////////////////////////////////////////////////////////////

// Эффективное решение, т.к. из найденной суммы отнимается предыдущий элемент и прибавляется следующий каждый раз
int[] GetRangeSum2(int[] array, int m)
{
  int n = array.Length;
  int[] t = new int[n - m + 1];

  int index = 0;
  for (int i = 0; i < m; i++) t[index] += array[i];

  for (int i = 1; i <= n - m; i++)
  {
    index++;
    t[index] = t[index - 1] - array[i - 1] + array[i + m - 1];
  }
  return t;
}
int[] CreateArray(int size) => new int[size];
string Print(int[] array) => $"[{String.Join(", ", array)}]";
void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray();
int[] numbers = CreateArray(5000);
Fill(ref numbers);
Console.WriteLine(Print(numbers));
int count = 200;
int[] sumGroupNumbers = GetRangeSum2(numbers, count);
Console.WriteLine(Print(sumGroupNumbers));
Console.WriteLine("+");