void Creat(int[] array, int min, int max) // Создаем массив рандомно.
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1); // Числа от 0 до 20.
}
int[] Output(int[] array) // Вывод массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]}");
    return array;
}
int Pivot(int[] array, int min, int max) // Опорный элемент
{
    int pivot = min - 1;
    int temp = 0;
    for (int i = min; i < max; i++)
    {
        if (array[max] > array[i])
        {
            pivot++;
            temp = array[pivot];
            array[pivot] = array[i];
            array[i] = temp;
        }
    }
    pivot++;
    temp = array[pivot];
    array[pivot] = array[max];
    array[max] = temp;
    return pivot;
}
int[] Quik(int[] array, int min, int max) // Рекурсивный расчет
{
    if(min >= max)
        return array;
    int pivot = Pivot(array, min, max); // pivot принимает значение из метода Pivot.    
    Quik(array, min, pivot - 1);
    Quik(array, pivot + 1, max);
    return array;
}

Console.WriteLine("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Creat(arr, min, max);
Output(arr);
Console.WriteLine();
arr = Quik(arr, 0, arr.Length - 1);
Output(arr);

