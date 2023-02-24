// В первой строке записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100). 
// Вторая строка содержит N чисел. Каждый элемент массива – натуральное число от 1 до 31. 
// Все элементы массива разделены пробелом.
// Нужно вывести нечетные числа, во второй четные числа. 
// В третьей строке нужно вывести «YES», если четных больше и «NO» в противном случае.

int ArrOdd(int[] array, int n)
{
    int odd = 0; // нечетные
    int count_odd = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] % 2 != 0)
        {
            odd = array[i];
            count_odd = count_odd + 1;
            Console.Write($"{odd} ");
        }
    }
    return count_odd;
}

int ArrEven(int[] array, int n)
{
    int even = 0; // четные
    int count_even = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] % 2 == 0)
        {
            even = array[i];
            count_even = count_even + 1;
            //Console.Write($"{even} ");
        }
    }
    return count_even;
}

Console.Clear();
Console.Write("Введите число N от 1 до 31: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через пробел: ");
int[] array = new int[n];
array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();




// for(int i = 0; i < n; i++)
// {
//     if(array[i] % 2 != 0)
//     {
//         odd = array[i];
//         count_odd = count_odd + 1;
//         Console.Write($"{odd} ");
//     }
// }   

// for(int i = 0; i < n; i++)
// { 
//     if(array[i] % 2 == 0)
//     {
//         even = array[i];
//         count_even = count_even + 1;
//         Console.Write($"{even} ");
//     }  
// }



ArrOdd(array, n);
Console.WriteLine();
ArrEven(array, n);
Console.WriteLine();

// Console.Write($"{ArrOdd(array, n)}");
// Console.WriteLine();
// Console.Write($"{ArrEven(array, n)}");

if(ArrOdd(array, n) > ArrEven(array, n))
{
    Console.Write("NO");
}
    
else Console.Write("YES");


