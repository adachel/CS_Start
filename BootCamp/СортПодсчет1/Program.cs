// Сортировка подсчетом

void CreatArray(int[] array, int[] size) // Создаем рандомный массив
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(size[0], size[1] + 1);
    
}

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ",  ");
//     }
// }

// void CountingSort(int[] inputArray) // Базовый метод. Работает с числами от 0 до 10.
// {
//     int[] counters = new int[10]; //массив повторений

//     for (int i = 0; i < inputArray.Length; i++) // Запись кол-во элементов в counters
//     {
//         counters[inputArray[i]]++;
//         // ourNumber = inputArray[i];
//         // counters[ourNumber]++;
//     }

//     int index = 0; // Нужен, чтобы ходить по исходному массиву
//     for (int i = 0; i < counters.Length; i++)  // Возвращаем отсортированные элементы
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }
// }

void CountingSortExtended(int[] inputArray) // Модернизированный метод. Расширяет функционал сортировки
{
    int max = inputArray.Max(); // Находит мах элемент
    int min = inputArray.Min(); // Находит min элемент
    int offset = -min; // Смещение. Чтобы исп отрицательные числа.
    int[] counters = new int[max + offset + 1]; // Массив повторений.
    for (int i = 0; i < inputArray.Length; i++)
        counters[inputArray[i] + offset]++;
    
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите экстремальные значения элементов через пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[] array = new int[n];
CreatArray(array, size);
//PrintArray(array);
Console.WriteLine();
CountingSortExtended(array);
//CountingSort(array);
Console.WriteLine(string.Join(",  ", array));