// Заполнение по диагоналям

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            //Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

 int[,] Transposition(int[,] matrix, int[,] temp)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //temp[i,j] = matrix[i,j];
            temp[1,0] = matrix[0,1]+1;

            temp[0,2] = matrix[1,0]+2;

            temp[1,1] = matrix[0,2]+2;
            temp[2,0] = matrix[1,1]+1;
            temp[0,3] = matrix[2,0]+1;
            temp[1,2] = matrix[0,3]+1;
            temp[2,1] = matrix[1,2]+1;
            temp[3,0] = matrix[2,1]+1;
           
        }
        Console.WriteLine();
    }
    return temp;
}

void PrintMatrix(int[,] temp)
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
Console.Write("Введите количество строк N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов M = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[,] temp = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Транспонирование по горизонтали:");
Transposition(matrix, temp);
PrintMatrix(temp);