// See https://aka.ms/new-console-template for more information

/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
/*
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}
*/

string Creat(int[] array)
{
    string count = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 21);
        count = count + $" {array[i]} ";
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
            for (int i = 0; i < array.Length - 1 - j; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
        }
        count = count + $" {array[k]} ";
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите кол - во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
Console.WriteLine("[" + Creat(a) + "]");
Console.WriteLine();
Console.WriteLine("[" + Calc(a) + "]");




