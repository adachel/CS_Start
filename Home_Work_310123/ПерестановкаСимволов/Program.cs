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


/*
// Код препода
void rec(string s2, string c)
{
    string s1;
    int i;
    if (s2.Length == 0)
        Console.WriteLine(c);
    else
    {
        for (i = 0; i < s2.Length; i++)
        {
            c += s2[i];
            s1 = s2;
            s1 = s1.Remove(i, 1);
            rec(s1, c);
            c = c.Remove(c.Length - 1, 1);
        }
    }
}


Console.Clear();
string? s = Console.ReadLine(), c, s2;
for(int i = 0; i < s.Length; i++)
{
    c = s[i].ToString();
    s2 = s;
    s2 = s2.Remove(i, 1);
    //Console.WriteLine(s2);
    rec(s2, c);
}

*/

