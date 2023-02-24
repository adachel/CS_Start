// See https://aka.ms/new-console-template for more information

// int n = 5;
// int[] array = new int[n];
// for(int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]"); // Join - соединяет элементы массива через "разделитель".
// // [4, 5, 3, 1, 2]
// int summa = 0;
// for(int i = 0; i < n; i++)
//     summa += array[i];
// Console.WriteLine(summa);


// int n = Convert.ToInt32(Console.ReadLine()); // Нужно уменьшить кол-во итераций
// int[,] matrix = new int[n + 1, n + 1];
// for(int i = 1; i <= n; i++)
// {
//     for(int j = 1; j <= n; j++)
//     {
//         matrix[i, j] = i * j;
//         Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
// }


int n = Convert.ToInt32(Console.ReadLine()); // Уменьшили кол-во итераций
int[,] matrix = new int[n, n];
for(int i = 0; i < n; i++)
{
    for(int j = i; j < n; j++)
    {
            matrix[i, j] = (i + 1) * (j + 1);
            matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" \t");
    }
    Console.WriteLine();
}