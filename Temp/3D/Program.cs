// Заполнение по диагоналям

void FillMatrix(int[,,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = i;
            }
            
        }
    }
}

void ScreenMatrix(int[,,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} \t");
            }
            
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,,] matrix)
{
    for(int k = 0; k <= matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if (matrix[i, j, k] < matrix[i, j + 1, k]) 
                {
                    int temp = matrix[i, j, k];
                    matrix[i, j, k] = matrix[i, j + 1, k];
                    matrix[i, j + 1, k] = temp;   
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
//ReleaseMatrix(matrix);
ScreenMatrix(matrix);
