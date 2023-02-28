// Сортировка выбором. Мой код.

string Creat(int[] array)
{
    string count = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 21);
        count = count + $"{array[i]} ";
    }
    return count;
}

string Calc(int[] array)
{
    string count = string.Empty;
    for (int k = 0; k < array.Length; k++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            int max = 0;
            int temp = 0;

            for (int i = 0; i < array.Length - j; i++)
            {
                if (array[i] > temp)
                {
                    max = i;
                    temp = array[max];
                }
            }
            array[max] = array[array.Length - 1 - j];
            array[array.Length - 1 - j] = temp;
        }
        count = count + $"{array[k]} ";
    }
    return count;

}
Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Начальный массив: ");
Console.Write($"{Creat(arr)}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Конечный массив: ");
Console.Write($"{Calc(arr)}");













