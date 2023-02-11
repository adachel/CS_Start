// Программа, которая задаёт массив из 8 элементов 
// и выводит их на экран(ввод пользователя с клавиатуры).

Console.Clear();
Console.WriteLine("Введите 8 элементов массива: ");
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"Результат: {string.Join(", ", array)}");

