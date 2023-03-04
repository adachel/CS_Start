// Первая строка содержит целые числа n и m (1 ≤ n, m ≤ 100).
// Каждая строка состоит из m символов «B» и «W».
// Далее следует пустая строка, а после нее,
// полученный Мишиной программой негатив в том же формате.
// Необходимо вывести число пикселей негатива, которые неправильно сформированы Мишиной программой.

void InputMatrixFirst(int[,] matrixFirst)
{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        string? input = Convert.ToString(Console.ReadLine())!;
        for (int j = 0; j < input.Length; j++)
        {
            matrixFirst[i, j] = input[j];
        }
    }
}
 
 
void InputMatrixSecond(int[,] matrixSecond)
{
    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        string? input = Console.ReadLine()!;
        for (int j = 0; j < input.Length; j++)
        {
            matrixSecond[i, j] = input[j];
        }
    }
}
 
 
void ReleaseMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int count = 0;
    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            if (matrixFirst[i, j] == matrixSecond[i, j])
                count++;
        }
    }
    Console.WriteLine($"{count}");
}
 
 
Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine()!.Split(' '); // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrixFirst = new int[n, m];
int[,] matrixSecond = new int[n, m];
InputMatrixFirst(matrixFirst);
Console.WriteLine();
InputMatrixSecond(matrixSecond);
	ReleaseMatrix(matrixFirst, matrixSecond);