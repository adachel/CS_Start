// Напишите программу, которая заполнит спирально массив 4 на 4.

void ScreenMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int size = 4;
int[,] matrix = new int[size, size];

int count = 1;
int i = 0;
int j = 0;
while(count <= 4 * 4)
{
    matrix[i, j] = count;
    count++;
    if(i <= j + 1 && i + j < size - 1) j++;
    else if(i < j && i + j >= size - 1) i++;
    else if(i >= j && i + j >= size) j--;
    else if(i > j + 1 && i + j < size) i--;
}
ScreenMatrix(matrix);