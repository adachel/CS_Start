double[,] GenerateMatrix(int rows, int columns) // Генерация матрицы, row - кол-во строчек, column - столбиков
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Random.Shared.Next(0, 5);
        }
    }

    return result;
}

void Print(double[,] matrix) // Метод печати матрицы
{
    int rows = matrix.GetLength(0); // Кол-во строк
    int columns = matrix.GetLength(1); // Кол-во столбиков
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MultiPlySync(double[,] matrixOne, double[,] matrixTwo) // Расчет синхр методом.
{
    int mrowsOne = matrixOne.GetLength(0), // Кол-во строк в первой матрице.
        k = matrixOne.GetLength(1), // Столбиков в первой. 
        mcolumsTwo = matrixTwo.GetLength(1); // Кол - во столбиков во второй.
    double[,] result = new double[mrowsOne, mcolumsTwo];
    for (int i = 0; i < mrowsOne; i++)
    {
        for (int j = 0; j < mcolumsTwo; j++)
        {
            double s = 0;
            for (int r = 0; r < k; r++)
            {
                s += matrixOne[i, r] * matrixTwo[r, j];
            }
            result[i, j] = s;
        }
    }
    return result;
}

double[,] MultiPlyParall(double[,] matrixOne, double[,] matrixTwo) // Расчет параллельным методом. Асинхронно.
{
    int mrowsOne = matrixOne.GetLength(0), // Кол-во строк в первой матрице.
        k = matrixOne.GetLength(1), // Столбиков в первой. 
        mcolumsTwo = matrixTwo.GetLength(1); // Кол - во столбиков во второй.
    double[,] result = new double[mrowsOne, mcolumsTwo];
    Parallel.For(0, mrowsOne, i => // Распараллеливает, кол-во потоков выбирается автоматически
    {
        for (int j = 0; j < mcolumsTwo; j++)
        {
            double s = 0;
            for (int r = 0; r < k; r++)
            {
                s += matrixOne[i, r] * matrixTwo[r, j];
            }
            result[i, j] = s;
        }
    }
    );
    return result;
}

Console.Write("Ведите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
var matrixOne = GenerateMatrix(n, n);
// Print(matrixOne);
var matrixTwo = GenerateMatrix(n, n);
// Print(matrixTwo);

DateTime s = DateTime.Now; // Время начала операции.
var resSyns = MultiPlySync(matrixOne, matrixTwo); // Результат перемножения.
//Print(resSyns); // Распечатать результат
DateTime e = DateTime.Now; // Время конца операции.
Console.WriteLine((e - s).TotalMilliseconds); // Время выполнения в милисекундах.

DateTime sp = DateTime.Now;
var resParall = MultiPlyParall(matrixOne, matrixTwo); // Результат перемножения
//Print(resParall); // Распечатать результат
DateTime ep = DateTime.Now;
Console.WriteLine((ep - sp).TotalMilliseconds);

Console.WriteLine("+");


