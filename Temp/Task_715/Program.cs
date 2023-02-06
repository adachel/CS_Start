// Первая строка содержит целые числа n и m (1 ≤ n, m ≤ 100).
// Каждая строка состоит из m символов «B» и «W».
// Далее следует пустая строка, а после нее,
// полученный Мишиной программой негатив в том же формате.
// Необходимо вывести число пикселей негатива, которые неправильно сформированы Мишиной программой.

/*
void InputMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (char)new Random().Next('0', '2');
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Transposition(char[,] temp, char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != '0')
                temp[i, j] = 'W';
            else if (matrix[i, j] != '1') 
                temp[i, j] = 'B';
            
            
        }
        Console.WriteLine();
    }

}

void PrintMatrix(char[,] temp)
{
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        for (int j = 0; j < temp.GetLength(1); j++)
        {
            Console.Write($"{temp[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
// Console.Write("Введите количество строк N = ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов M = ");
// int m = Convert.ToInt32(Console.ReadLine());
char[,] matrix = new char[5, 4];
char[,] temp = new char[5, 4];
InputMatrix(matrix);

Console.WriteLine("Транспонирование по горизонтали:");
Transposition(matrix, temp);
PrintMatrix(matrix);
*/


