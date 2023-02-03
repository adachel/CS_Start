// Дана строка, состоящая из N символов (1 ≤ N ≤ 8), 
// символы - буквы английского алфавита и цифры.
// Выведите в каждой строке по одной перестановке. 
// Перестановки можно выводить в любом порядке. 
// Повторений и строк, не являющихся перестановками исходной, быть не должно.

Console.Clear();
Console.Write("Введите не более восьми букв и цифр: ");
string? n = Console.ReadLine()!;
int length = Convert.ToInt32(n.Length); // Присваиваем Length длину текста.
if (length >8)
{
    Console.Write("Введите не более ВОСЬМИ букв и цифр!");
    return;
}
char[] c = n.ToCharArray(); // Конвертируем в char

//Console.WriteLine($"Длина: {length}");
//Console.WriteLine($"Начальный массив: [{string.Join("  ", c)}]");

for (int j = 0; j < length; j++)
{
    for (int i = 0; i < length - 1; i++)
    {
        char temp = c[i];
        c[i] = c[i + 1];
        c[i + 1] = temp;

    Console.WriteLine($"[{string.Join("  ", c)}]");   
    }
}





