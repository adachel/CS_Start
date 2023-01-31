/*
Console.Clear();
string[,] table = new string[2, 5]; // Две строки с индексами 0.0 и 1.0
                                    // Пять столбцов с инд с 0.0 до 0.4
                                    // Инициализация строк String.Empty

table[1, 2] = "Слово";
for (int rows = 0; rows < 2; rows++) // Создаем строки
{
    for (int columns = 0; columns < 5; columns++) // Создаем столбцы
    {
        Console.WriteLine($" -{table[rows, columns]}- ");
    }
}
*/
/*
Console.Clear();
int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) конец массива, вместо "3".
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} "); // Выводим в строку
    }
    Console.WriteLine(); // Переход на новую строку
}
*/




void PrintArray(int[,] matr) // В виде процедуры
{
for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) конец массива, вместо "3".
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} "); // Выводим в строку
    }
    Console.WriteLine(); // Переход на новую строку
}
}

void FillArray(int[,] matr) // Заполняем случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.Clear();
int[,] matrix = new int[3, 4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
