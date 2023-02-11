// Собираем строку с числами от а до b, а >= b
/*
string NumbersFor (int a, int b) // Инеративный подход
{
    string resalt = string.Empty;
    for (int i = 0; i < b; i--)
    {
        resalt += $"{a} ";
    }
    return resalt;
}

string NumbersRec (int a, int b) // Рекурсивный подход
{
    if (a <= b) 
    {
        NumbersRec (a + 1, b) + $"{a} "; // Где-то ошибка  
    }
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));
*/





// Сумма от 1 до n
/*
int SumFor (int n)
{
    int resalt = 0;
    for (int i = 0; i <= n; i++) resalt += i;
    return resalt;
}

int SumRec (int n)
{
    if (n == 0) return 0; // Условие выхода
    else return n + SumRec (n - 1);
}

Console.WriteLine(SumFor(20));
Console.WriteLine(SumRec(10));
*/



// Факториал чиала
/*
int FactorialFor (int n)
{
    int resalt = 1;
    for (int i = 1; i <= n; i++) resalt *= i;
    return resalt;
}

int FactorialRec (int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec (n-1);
}

Console.WriteLine(FactorialFor(5));
Console.WriteLine(FactorialRec(5));
*/


// Вычисляем а в степени n
/*
int PowerFor (int a, int n)
{
    int resalt = 1;
    for (int i = 1; i <= n; i++) resalt *= a;
    return resalt;
}

int PowerRec (int a, int n)
{
    return n == 0 ? 1: PowerRec (a, n - 1) * a; // Можно в одну строку
    // if (n == 0) return 1;
    // else return PowerRec (a, n - 1) * a;
}

int PowerRecMath (int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath (a * a, n / 2);
    else return PowerRecMath (a, n - 1) * a;
}

Console.WriteLine(PowerFor(5, 5));
Console.WriteLine(PowerRec(5, 5));
Console.WriteLine(PowerRecMath(5, 5));
*/





// Пусть у нас будет некоторый алфавит, состоящий из четырёх букв, 
//и нас просят показать все возможные слова, состоящие из T букв. Т может равняться 1, 2, 3 и так далее.
// Общее решение
/*
int n = 1;
void FindWords (string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords (alphabet, word, length + 1);
    }
}

FindWords ("ASDF", new char[5]);
*/


// Просмотр содержимого папок
/*
void CatalogInfo (string path, string indent = "") // string indent делает отступы, чтобы лучше видеть структуру папки
{
    DirectoryInfo catalogs = new DirectoryInfo(path); // Получаем инфо о директории
    foreach(var carrentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent} {carrentCatalog.Name}");
        CatalogInfo(carrentCatalog.FullName, indent + " ");
    }

    foreach(var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent} {item.Name}");
    }
}
string path = @"D:\Works\IT"; // Директория
CatalogInfo(path);
*/



// Игра в пирамидки
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 5) // На 1 лежат, через 2, перекладываем 
                                                                                  // на 3. count - кол блинов.
{
    if(count > 1) Towers(with, some, on, count - 2);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count - 1);

}
Towers();
*/


// Обход разных структур
/*
string emp = string.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"}; // первый emp нужен, чтоб вся строчка вмещалась

void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int rigth = 2 * pos + 1;
        if(left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(rigth < tree.Length && !string.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
    }
}
InOrderTraversal();
*/

