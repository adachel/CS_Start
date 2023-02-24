// Вводим с клавиатуры 

// void InputMatrixFirst(int[,] matrixFirst)
// {
//     for (int i = 0; i < matrixFirst.GetLength(0); i++)
//     {
//         string? input = Convert.ToString(Console.ReadLine())!;
//         for (int j = 0; j < input.Length; j++)
//         {
//             matrixFirst[i, j] = input[j];
//         }
//     }
// }



int[] array = new int[5];
for(int i = 0; i < 5; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]"); // Join - соединяет элементы массива через "разделитель".