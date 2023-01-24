/*
// String(char)
string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);
*/

/*
// Array Выводит элементы в массив
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); // [-10, 10]

Console.WriteLine($"Результат: [{string.Join(", ", array)}]");


// Function(void)
void f(ref int n) // ref - передача значение по ссылке
{
    n = n + 5;
}

int n = 10;
f(ref n);
Console.WriteLine(n);
*/


/*
// Function(void)
void f(int[] n)
{
    n[0] = n[0] + 5;
}

int[] n = {1, 2, 3, 4, 5};
f(n);
Console.WriteLine(string.Join(" ", n));
*/

/*
int f(int a, int b)
{
    if (a > b)
        return a;
    return b;
}


int a = 10, b = 7;
Console.WriteLine(f(a, b));
*/

