int F(int[] arr, int min, int max)
{
    int p = min - 1;
    int temp = 0;
    for (int i = min; i < max; i++)
    {
        if (arr[max] > arr[i])
        {
            p++;
            temp = arr[i];
            arr[i] = arr[p];
            arr[p] = temp;
        }
    }

    p++;
    temp = arr[p];
    arr[p] = arr[max];
    arr[max] = temp;
    return p;
}

int[] Q(int[] arr, int min, int max)
{
    if(min >= max)
        return arr;
    int p = F(arr, min, max);
    Q(arr, min, p - 1);
    Q(arr, p + 1, max);
    return arr;
}

Console.WriteLine("Введите размер массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int n = 10;
int[] arr = { 7, 6, 3, 9, 8, 5, 1, 0, 2, 4 };
for (int i = 0; i < arr.Length; i++)
    Console.Write($" {arr[i]}");
Console.WriteLine();    

arr = Q(arr, 0, arr.Length - 1);
for (int i = 0; i < arr.Length; i++)
    Console.Write($" {arr[i]}");
